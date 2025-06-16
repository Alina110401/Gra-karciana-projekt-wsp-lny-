using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uno
{
    public partial class GameForm : Form
    {
        private class Card
        {
            public string Color { get; set; }
            public string Value { get; set; }
            public override string ToString() => $"{Color} {Value}";
        }

        private List<List<Card>> playerHands = new();
        private List<Card> deck = new();
        private Stack<Card> discardPile = new();
        private int playerCount;
        private int currentPlayer = 0;
        private int direction = 1;
        private Random rng = new();
        public GameForm(int count)
        {
            InitializeComponent();
            playerCount = count;
            InitDeck();
            DealCards();
            Card firstCard;
            do
            {
                firstCard = DrawCard();
            } while (
                firstCard.Color == "Wild" ||
                firstCard.Value == "+2" ||
                firstCard.Value == "+4" ||
                firstCard.Value == "Skip" ||
                firstCard.Value == "Reverse"
            );
            discardPile.Push(firstCard);

            UpdateUI();
        }
        private void InitDeck()
        {
            string[] colors = { "Red", "Green", "Blue", "Yellow" };
            string[] values = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "Skip", "Reverse", "+2" };

            foreach (var color in colors)
            {
                foreach (var value in values)
                {
                    deck.Add(new Card { Color = color, Value = value });
                    deck.Add(new Card { Color = color, Value = value });
                }
            }

            // Wild and +4
            for (int i = 0; i < 4; i++)
            {
                deck.Add(new Card { Color = "Wild", Value = "Color" });
                deck.Add(new Card { Color = "Wild", Value = "+4" });
            }
            deck = deck.OrderBy(x => rng.Next()).ToList();
        }

        private void DealCards()
        {
            for (int i = 0; i < playerCount; i++)
            {
                var hand = new List<Card>();
                for (int j = 0; j < 7; j++)
                {
                    hand.Add(DrawCard());
                }
                playerHands.Add(hand);
            }
        }

        private Card DrawCard()
        {
            if (deck.Count == 0)
            {
                deck = discardPile.Reverse().Skip(1).ToList();
                discardPile = new Stack<Card>(new[] { discardPile.Peek() });
            }
            var card = deck[0];
            deck.RemoveAt(0);
            return card;
        }
        private void buttonDraw_Click(object sender, EventArgs e)
        {
            playerHands[currentPlayer].Add(DrawCard());
            AdvanceTurn();
        }
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (listBoxHand.SelectedIndex >= 0)
            {
                var selected = playerHands[currentPlayer][listBoxHand.SelectedIndex];
                var top = discardPile.Peek();

                if (selected.Color == top.Color || selected.Value == top.Value || selected.Color == "Wild")
                {
                    playerHands[currentPlayer].RemoveAt(listBoxHand.SelectedIndex);
                    discardPile.Push(selected);
                    HandleSpecialCard(selected);

                    if (playerHands[currentPlayer].Count == 0)
                    {
                        MessageBox.Show($"Игрок {currentPlayer + 1} победил!");
                        Application.Exit();
                    }
                    else
                        AdvanceTurn();
                }
                else
                {
                    MessageBox.Show("Эту карту нельзя положить.");
                }
            }
        }


        private void listBoxHand_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxHand.SelectedIndex >= 0)
            {
                var selected = playerHands[currentPlayer][listBoxHand.SelectedIndex];
                var top = discardPile.Peek();
                if (selected.Color == top.Color || selected.Value == top.Value || selected.Color == "Wild")
                {
                    playerHands[currentPlayer].RemoveAt(listBoxHand.SelectedIndex);
                    discardPile.Push(selected);
                    HandleSpecialCard(selected);
                    if (playerHands[currentPlayer].Count == 0)
                    {
                        MessageBox.Show($"Игрок {currentPlayer + 1} победил!");
                        Application.Exit();
                    }
                    else
                        AdvanceTurn();
                }
            }
        }

        private void HandleSpecialCard(Card card)
        {
            if (card.Value == "Skip") AdvanceTurn();
            else if (card.Value == "Reverse") direction *= -1;
            else if (card.Value == "+2")
            {
                int next = GetNextPlayer();
                playerHands[next].Add(DrawCard());
                playerHands[next].Add(DrawCard());
                AdvanceTurn();
            }
            else if (card.Value == "+4")
            {
                int next = GetNextPlayer();
                for (int i = 0; i < 4; i++) playerHands[next].Add(DrawCard());
                AdvanceTurn();
            }
            else if (card.Value == "Color")
            {
                string color = Prompt.ShowDialog("Выбери цвет (Red/Green/Blue/Yellow)", "Смена цвета");
                card.Color = color;
            }
        }

        private void AdvanceTurn()
        {
            currentPlayer = GetNextPlayer();
            var passForm = new PassTurnForm(currentPlayer + 1);
            passForm.ShowDialog();
            UpdateUI();
        }

        private int GetNextPlayer()
        {
            return (currentPlayer + direction + playerCount) % playerCount;
        }

        private void UpdateUI()
        {
            labelCurrent.Text = $"Ход игрока {currentPlayer + 1}";
            labelTopCard.Text = $"Верхняя карта: {discardPile.Peek()}";
            listBoxHand.Items.Clear();
            foreach (var card in playerHands[currentPlayer])
                listBoxHand.Items.Add(card.ToString());

            listBoxCounts.Items.Clear();
            for (int i = 0; i < playerCount; i++)
                listBoxCounts.Items.Add($"Игрок {i + 1}: {playerHands[i].Count} карт");
        }

        private void buttonUno_Click(object sender, EventArgs e)
        {
            if (playerHands[currentPlayer].Count == 1)
                MessageBox.Show("УНО подтверждено!");
            else
                MessageBox.Show("УНО нельзя кричать сейчас.");
        }
    }

    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form() { Width = 250, Height = 150, Text = caption };
            Label lbl = new Label() { Text = text, Left = 10, Top = 10 };
            TextBox input = new TextBox() { Left = 10, Top = 40, Width = 200 };
            Button ok = new Button() { Text = "OK", Left = 60, Top = 70, Width = 100 };
            ok.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(lbl); prompt.Controls.Add(input); prompt.Controls.Add(ok);
            prompt.ShowDialog();
            return input.Text;
        }
    }
}
