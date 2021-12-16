using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DurakLib;
using CardBox;
using System.Threading;

namespace DurakGame
{
    public partial class Game : Form
    {
        private Table gameTable;
        private Player player1;
        private PlayerAI player2;
        private bool gameEnded = false;

        private const int MAX_CONTAINER_CARDS = 6; // The max. number of cards that can fit in
                                                   // a single row of the FlowPanelLayout
        public Game()
        {
            InitializeComponent();
            gameTable = new Table();
            player1 = new Player("Player 1");
            player2 = new PlayerAI("AI Player");
            gameTable.dealCardsToMultiplePlayers(player1, player2, 12);
        }

        public Game(String name, bool transferEnabled, int deckSize)
        {
            InitializeComponent();
            gameTable = new Table(deckSize);
            gameTable.Transfers = transferEnabled;
            player1 = new Player(name);
            player2 = new PlayerAI("AI Player");
            gameTable.dealCardsToMultiplePlayers(player1, player2, 12);
        }


        private void Game_Load(object sender, EventArgs e)
        {
            setupWindow();
            refreshPlayerHandView(1);
            refreshPlayerHandView(2);
            List<Player> players = new List<Player>();
            players.Add(player1);
            players.Add(player2);
            Card trumpCard = gameTable.DrawCardFromDeck();
            // Add trump card to the end of the deck so that it can be drawn in end game
            gameTable.CardsDeck.Add(trumpCard);
            gameTable.TrumpCard = trumpCard;
            cbTrump.Card = trumpCard;
            cbTrump.FaceUp = true;
            cbTrump.CardOrientation = Orientation.Horizontal;
            //cbTrump.Update();

            gameTable.determineInitialAttacker(players);
            Console.WriteLine("The attacker is player " + gameTable.CurrentTurn);
            updateAttackStatus(gameTable.CurrentTurn);
            updateTurn(gameTable.CurrentTurn);

            // Testing purpose: Human player as initial attacker
            //updateAttackStatus(2);
            //updateTurn(2);

            updateDeckSizeLabel();
        }

        private void setupWindow()
        {
            this.BackColor = Color.FromArgb(3, 30, 84);
            this.Size = new Size(this.Width, this.Height + 50);
            flpPlayerHand.BackColor = Color.FromArgb(3, 48, 118);
            //flpPlayerHand.Location = new Point(flpPlayerHand.Location.X, this.Height - flpPlayerHand.Size.Height - 30);
            flpAIHand.BackColor = Color.FromArgb(3, 48, 118);
            lblAttackStatus.BackColor = Color.FromArgb(2, 25, 68);
            lblAttackStatus.ForeColor = Color.FromArgb(120, 151, 198);
            btnAction.BackColor = Color.FromArgb(114, 187, 8);
           
            Console.WriteLine("The windows height is " + this.Height);
            Console.WriteLine("The control height is " + flpPlayerHand.Height);
        }

        private void Player1Card_Click(object sender, System.EventArgs e)
        {
         
            if (gameEnded)
            {
                return;
            }
            CardPictureBox cardBox = (CardPictureBox)sender;
            // Console.WriteLine(cardBox.ToString());
            if (gameTable.isValidPick(cardBox.Card, player1.IsAttacking, 1))
            {
                this.flpPlayerHand.Controls.Remove(cardBox);
                player1.Hand.Remove(cardBox.Card);
                addCardToBout(cardBox);
                if (player1.Hand.Count == 0)
                {
                    endGame(player1);
                    return;
                }
                updateTurn(2);
                // Sleep for 2 seconds to imitate that AI is thinking
                //Thread.Sleep(2000);
              
            } else
            {
                // TO-DO: HANDLE EXCEPTION! Display error that selected card can't be picked
            }
            
        }

        private void AIMakeMove()
        {
            if (gameEnded)
            {
                return;
            }
            Card AIcard = player2.PickCard(gameTable);
            if (AIcard == null)
            {
                Console.WriteLine("AI didn't choose any card");
                if (player2.IsAttacking)
                {
                    Console.WriteLine("AI is the attacker.");
                    discardBoutCards();
                }
                else
                {
                    Console.WriteLine("AI is the defender.");
                    Console.WriteLine("Put all bout cards in AI deck.");
                    addBoutCardsToPlayerHand(player2);
                    clearBoutView();
                }
                refillAllPlayerHands();
                updateAttackStatus(1); // Human becomes attacker
                updateTurn(1); // Switch turn to Human
                return;
            }
            else
            {
                Console.WriteLine("AI chose a card: " + AIcard.ToString());
                CardPictureBox AICardBox = null;
                // Find the CardPictureBox of the selected card in the AI FlowLayoutPanel
                // Alternative: make a new CardPictureBox containing the selected card. It can beb removed this way too.
                foreach (CardPictureBox cbox in this.flpAIHand.Controls)
                {
                    if (cbox.Card == AIcard)
                    {
                        AICardBox = cbox;
                    }
                }

                if (AICardBox == null)
                {
                    // TO-DO: Show MessageBox and handle exception
                    Console.WriteLine("AICardBox is null! HANDLE EXCEPTION!");
                    return;
                }
                Console.WriteLine("Found cardbox for AI: " + AICardBox.ToString());
                this.flpAIHand.Controls.Remove(AICardBox);
                player2.Hand.Remove(AICardBox.Card);
                addCardToBout(AICardBox);
                updateTurn(1);
            }

               
        }

        private void refreshPlayerHandView(int player)
        {

            if (player == 1)
            {
                flpPlayerHand.Controls.Clear();
                //foreach(CardPictureBox cb in flpPlayerHand.Controls)
                //{
                //    flpPlayerHand.Controls.Remove(cb);
                //}
                //150, 232
                Console.WriteLine("Human's new hand is: ");
                for (int i = 0; i < player1.Hand.Count; i++)
                {
                    Card c = player1.Hand[i];
                    Console.WriteLine(c.ToString());
                    CardPictureBox cardbox = new CardPictureBox(c);
                    cardbox.FaceUp = true;
                    int newWidth = (int)(cardbox.Width / 1.4);
                    int newHeight = (int)(cardbox.Height / 1.4);
                    cardbox.Size = new Size(newWidth, newHeight);
                    //if (!flpPlayerHand.Controls.Contains(cardbox))
                    //{
                    flpPlayerHand.Controls.Add(cardbox);
                        cardbox.Click += new EventHandler(Player1Card_Click);
                    //}
                }
            }
            else if (player == 2)
            {
                flpAIHand.Controls.Clear();
                //foreach (CardPictureBox cb in flpAIHand.Controls)
                //{
                //    flpAIHand.Controls.Remove(cb);
                //}
                for (int i = 0; i < player2.Hand.Count; i++)
                {
                    CardPictureBox cardbox = new CardPictureBox(player2.Hand[i]);
                    //cardbox.FaceUp = false;
                    cardbox.FaceUp = true; // testing purposes
                    int newWidth = (int)(cardbox.Width / 1.4);
                    int newHeight = (int)(cardbox.Height / 1.4);
                    cardbox.Size = new Size(newWidth, newHeight);
                    //if (!flpAIHand.Controls.Contains(cardbox))
                    //{
                    flpAIHand.Controls.Add(cardbox);
                    //}

                }
            }
        }

        private void addCardToBout(CardPictureBox cardBox)
        {
            cardBox.FaceUp = true;
            const double divider = 1.3;
            int newWidth = (int)(cardBox.Width / divider);
            int newHeight = (int)(cardBox.Height / divider);
            cardBox.Size = new Size(newWidth, newHeight);
            flpBout.Controls.Add(cardBox);
            gameTable.BoutCards.Add(cardBox.Card);
        }

        private void updateAttackStatus(int attacker)
        {
            if (attacker == 1)
            {
                lblAttackStatus.Text = "You are the attacker";
                player1.IsAttacking = true;
                player2.IsAttacking = false;
            }
            else
            {
                lblAttackStatus.Text = "You are the defender";
                player1.IsAttacking = false;
                player2.IsAttacking = true;
            }
        }

        private void updateDeckSizeLabel()
        {
            lblDeckSize.Text = gameTable.GetDeckSize().ToString();
        }

        private void updateTurn(int turn)
        {
            gameTable.CurrentTurn = turn;
            
            // It is human's turn
            if (turn == 1)
            {
                if (player1.IsAttacking)
                {
                    btnAction.Text = "PASS";
                    // It's beginning of a new bout, don't display PASS button
                    if (gameTable.BoutCards.Count == 0)
                    {
                        btnAction.Visible = false;
                    } else
                    {
                        btnAction.Visible = true;
                    }

                }
                else
                {

                    btnAction.Visible = true;
                    btnAction.Text = "TAKE";
                }
            }
            // It is AI's turn
            else if (turn == 2)
            {
                btnAction.Visible = false;
                if (!gameEnded)
                {
                    AIMakeMove();
                }
                if (player2.Hand.Count == 0)
                {
                    endGame(player2);
                    return;
                }
            }
        }

        private void endGame (Player winner)
        {
            Console.WriteLine("The winner is: " + winner.GetName());
            gameEnded = true;
            btnAction.Visible = false;
        }

        private void discardBoutCards()
        {
            Console.WriteLine("Discarding all bout cards...");
            foreach(Card card in gameTable.BoutCards)
            {
                gameTable.DiscardDeck.Add(card);
            }
            clearBoutView();
        }
        private void clearBoutView()
        {
            gameTable.BoutCards.Clear();
            flpBout.Controls.Clear();
        }

        private void refillAllPlayerHands()
        {
            Console.WriteLine("Refilling player hands");
            if (player1.Hand.Count < 6)
            {
                Console.WriteLine("# of cards added to human hand: " + (6 - player1.Hand.Count));
                try
                {
                    if (gameTable.DeckSize > 0)
                    {
                        gameTable.dealCardsToPlayer(player1, 6 - player1.Hand.Count);
                    }
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("Out oof range exception: " + e.Message);
                }
            }

            if (player2.Hand.Count < 6)
            {
                Console.WriteLine("# of cards added to AI hand: " + (6 - player2.Hand.Count));
                try
                {
                    if (gameTable.DeckSize > 0)
                    {
                        gameTable.dealCardsToPlayer(player2, 6 - player2.Hand.Count);
                    }
                }
                catch (IndexOutOfRangeException e)
                {
                
                    Console.WriteLine("Out oof range exception: " + e.Message);
                }
            }
            refreshPlayerHandView(1);
            refreshPlayerHandView(2);
            updateDeckSizeLabel();
        }

        private void addBoutCardsToPlayerHand(Player player)
        {
            Console.WriteLine("# of cards to add: " + gameTable.BoutCards.Count);
            Console.WriteLine("Total before: " + player.Hand.Count);
            foreach (Card card in gameTable.BoutCards)
            {
                player.Hand.Add(card);
            }
            Console.WriteLine("Total after: " + player.Hand.Count);
        }


        private void btnAction_Click(object sender, EventArgs e)
        {
            if (gameEnded)
            {
                return;
            }
            // Check if it's human's turn
            if (gameTable.CurrentTurn == 1)
            {
                // Player wants to "Pass"
                if (player1.IsAttacking)
                {
                    discardBoutCards();
                }
                // Player wants to take the bout cards
                else
                {
                    Console.WriteLine("Adding cards to player human hand.");
                    addBoutCardsToPlayerHand(player1);
                    clearBoutView();
                    Console.WriteLine("Total player hand now: " + player1.Hand.Count);

                }
                refillAllPlayerHands();
                updateAttackStatus(2); // AI becomes attacker
                updateTurn(2); // Switch turn to AI
            }
        }
    }
}
