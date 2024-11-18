using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<string> playerNames = new List<string>();
        List<int> playerKills = new List<int>();
        List<int> playerDeaths = new List<int>();
        List<int> playerRetreats = new List<int>();
        List<int> CplayerKills = new List<int>();
        List<int> CplayerDeaths = new List<int>();
        List<int> CplayerRetreats = new List<int>();
        List<int> playerMadeRetreat = new List<int>();
        List<int> CplayerMadeRetreat = new List<int>();
        List<int> Warnings = new List<int>();
        List<string> WarningsString = new List<string>();
        List<int> Rankings = new List<int>();
        bool active = true;
        int scrollValue = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private IEnumerator valueCheck()
        {
            if (listBox1.TopIndex != scrollValue)
            {
                listBox1.TopIndex = scrollValue;
                Console.WriteLine("Aaaa");
            }
            Thread.Sleep(100);
            valueCheck();
            return null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                string text = textBox1.Text;
                if (textBox1.Text.Length > 20)
                {
                    text = textBox1.Text.Substring(0, 20);
                }

                listBox1.Items.Add(text);
                playerNames.Add(text);
                playerKills.Add(0);
                playerDeaths.Add(0);
                playerRetreats.Add(0);
                playerMadeRetreat.Add(0);
                CplayerKills.Add(0);
                CplayerDeaths.Add(0);
                CplayerRetreats.Add(0);
                CplayerMadeRetreat.Add(0);
                Warnings.Add(0);
                WarningsString.Add("");

                ListViewItem item = new ListViewItem();
                item.Text = text;
                item.SubItems.Add("0" + "K / " + "0" + "D / " + "0" + "R / " + "0" + "M");
                item.SubItems.Add("0" + "K / " + "0" + "D / " + "0" + "R / " + "0" + "M");
                item.SubItems.Add("");
                listView1.Items.Add(item);
                textBox1.Text = "";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                PlayerName.Text = listBox1.Text;
                KillsLabelCount.Text = CplayerKills[listBox1.SelectedIndex].ToString();
                DeathsLabelCount.Text = CplayerDeaths[listBox1.SelectedIndex].ToString();
                RetreatsLabelCount.Text = CplayerRetreats[listBox1.SelectedIndex].ToString();
                MadeRetreatLabel.Text = CplayerMadeRetreat[listBox1.SelectedIndex].ToString();
            }
        }

        private void listBox1_Change(object sender, EventArgs e)
        {
            PlayerName.Text = "Changed";
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                for(int i = 0; i < playerNames.Count; i++)
                {
                    if (playerNames[listBox1.SelectedIndex] == listView1.Items[i].Text)
                    {
                        listView1.Items.RemoveAt(i);
                        playerNames.RemoveAt(listBox1.SelectedIndex);
                        playerKills.RemoveAt(listBox1.SelectedIndex);
                        CplayerDeaths.RemoveAt(listBox1.SelectedIndex);
                        playerDeaths.RemoveAt(listBox1.SelectedIndex);
                        playerMadeRetreat.RemoveAt(listBox1.SelectedIndex);
                        CplayerMadeRetreat.RemoveAt(listBox1.SelectedIndex);
                        Warnings.RemoveAt(listBox1.SelectedIndex);
                        WarningsString.RemoveAt(listBox1.SelectedIndex);
                        listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                        PlayerName.Text = "N/A";
                        KillsLabelCount.Text = "0";
                        DeathsLabelCount.Text = "0";
                        RetreatsLabelCount.Text = "0";
                        MadeRetreatLabel.Text = "0";
                        listBox1.Update();
                        listBox1.SelectedIndex = -1;
                        break;

                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < playerNames.Count; i++)
            {
                CplayerKills[i] = 0;
                CplayerDeaths[i] = 0;
                CplayerRetreats[i] = 0;
                CplayerMadeRetreat[i] = 0;
                UpdateList();

            }

            listBox1.SelectedIndex = -1;
            PlayerName.Text = "N/A";
            KillsLabelCount.Text = "0";
            DeathsLabelCount.Text = "0";
            RetreatsLabelCount.Text = "0";
            MadeRetreatLabel.Text = "0";
        }

        private void KillButtonMinus_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1 && CplayerKills[listBox1.SelectedIndex] > -99)
            {
                playerKills[listBox1.SelectedIndex] -= 1;
                CplayerKills[listBox1.SelectedIndex] -= 1;
                KillsLabelCount.Text = CplayerKills[listBox1.SelectedIndex].ToString();
                UpdateList();
            }
        }

        private void KillButtonPlus_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1 && playerKills[listBox1.SelectedIndex] < 99)
            {
                playerKills[listBox1.SelectedIndex] += 1;
                CplayerKills[listBox1.SelectedIndex] += 1;
                KillsLabelCount.Text = CplayerKills[listBox1.SelectedIndex].ToString();
                UpdateList();
            }
        }

        private void RetreatButtonPlus_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1 && playerRetreats[listBox1.SelectedIndex] < 99)
            {
                playerRetreats[listBox1.SelectedIndex] += 1;
                CplayerRetreats[listBox1.SelectedIndex] += 1;
                RetreatsLabelCount.Text = CplayerRetreats[listBox1.SelectedIndex].ToString();
                UpdateList();
            }
        }

        private void RetreatButtonMinus_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1 && playerRetreats[listBox1.SelectedIndex] > -99)
            {
                playerRetreats[listBox1.SelectedIndex] -= 1;
                CplayerRetreats[listBox1.SelectedIndex] -= 1;
                RetreatsLabelCount.Text = CplayerRetreats[listBox1.SelectedIndex].ToString();
                UpdateList();
            }
        }

        private void DeathButtonPlus_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1 && playerDeaths[listBox1.SelectedIndex] < 99)
            {
                playerDeaths[listBox1.SelectedIndex] += 1;
                CplayerDeaths[listBox1.SelectedIndex] += 1;
                DeathsLabelCount.Text = CplayerDeaths[listBox1.SelectedIndex].ToString();
                UpdateList();
            }
        }

        private void DeathButtonMinus_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1 && playerDeaths[listBox1.SelectedIndex] > -99)
            {
                playerDeaths[listBox1.SelectedIndex] -= 1;
                CplayerDeaths[listBox1.SelectedIndex] -= 1;
                DeathsLabelCount.Text = CplayerDeaths[listBox1.SelectedIndex].ToString();
                UpdateList();
            }
        }

        private void MadeRetreatMinus_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1 && playerMadeRetreat[listBox1.SelectedIndex] > -99)
            {
                playerMadeRetreat[listBox1.SelectedIndex] -= 1;
                CplayerMadeRetreat[listBox1.SelectedIndex] -= 1;
                MadeRetreatLabel.Text = CplayerMadeRetreat[listBox1.SelectedIndex].ToString();
                UpdateList();
            }
        }

        private void MadeRetreatPlus_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1 && playerMadeRetreat[listBox1.SelectedIndex] < 99)
            {
                playerMadeRetreat[listBox1.SelectedIndex] += 1;
                CplayerMadeRetreat[listBox1.SelectedIndex] += 1;
                MadeRetreatLabel.Text = CplayerMadeRetreat[listBox1.SelectedIndex].ToString();
                UpdateList();
            }
        }

        private void UpdateList()
        {

            Rankings.Clear();
            for (int i = 0; i < playerNames.Count; i++)
            {
                int playerScore = 0;
                playerScore += playerKills[i] * 2;
                playerScore += playerMadeRetreat[i];
                // playerScore += playerRetreats[i] / 2;
                //playerScore -= playerDeaths[i];
                //playerScore += Warnings[i];

                Rankings.Add(playerScore);
            }
            listView1.Items.Clear();

            for (int i = 0; i < playerNames.Count; i++)
            {
                int HighestScore = -9999;
                int CurrentScore = 0;
                int CurrentPositioning = 0;
                for (int j = 0; j < Rankings.Count; j++)
                {
                    CurrentScore = Rankings[j];
                    if (CurrentScore == HighestScore)
                    {
                        if (playerRetreats[j] > playerRetreats[CurrentPositioning])
                        {
                            CurrentPositioning = j;
                        }
                        else
                        {
                            if (playerDeaths[j] < playerDeaths[CurrentPositioning])
                            {
                                CurrentPositioning = j;
                            }
                            else
                            {
                                if (Warnings[j] < Warnings[CurrentPositioning])
                                {
                                    CurrentPositioning = j;
                                }

                            }
                        }
                    }
                    else
                    {
                        if (CurrentScore > HighestScore)
                        {
                            CurrentPositioning = j;
                            HighestScore = CurrentScore;
                        }
                    }
                    if (j == Rankings.Count - 1)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = playerNames[CurrentPositioning];
                        item.SubItems.Add(CplayerKills[CurrentPositioning] + "K / " + CplayerDeaths[CurrentPositioning] + "D / " + CplayerRetreats[CurrentPositioning] + "R / " + CplayerMadeRetreat[CurrentPositioning] + "M");
                        item.SubItems.Add(playerKills[CurrentPositioning] + "K / " + playerDeaths[CurrentPositioning] + "D / " + playerRetreats[CurrentPositioning] + "R / " + playerMadeRetreat[CurrentPositioning] + "M");
                        item.SubItems.Add(WarningsString[CurrentPositioning]);
                        listView1.Items.Add(item);
                        Rankings[CurrentPositioning] = -9999;
                    }
                }
            }

        }
    private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1 && Warnings[listBox1.SelectedIndex] != 3)
            {
                string text = textBox2.Text;
                if (textBox1.Text.Length > 100)
                {
                    text = textBox1.Text.Substring(0, 100);
                }
                listBox6.Items.Add(listBox1.Items[listBox1.SelectedIndex].ToString() + " - Warning - " + textBox2.Text);

                Warnings[listBox1.SelectedIndex] = Warnings[listBox1.SelectedIndex] + 1;
                WarningsString[listBox1.SelectedIndex] = WarningsString[listBox1.SelectedIndex] + " X";
                UpdateList();
                textBox2.Text = "";

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1 && Warnings[listBox1.SelectedIndex] != 0)
            {
                WarningsString[listBox1.SelectedIndex] = WarningsString[listBox1.SelectedIndex].Substring(0, WarningsString[listBox1.SelectedIndex].ToString().Length - 2);
                listBox6.Items.Add(listBox1.Items[listBox1.SelectedIndex].ToString() + " - Removed Warning");
                Warnings[listBox1.SelectedIndex] = Warnings[listBox1.SelectedIndex] - 1;
                UpdateList();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string text = textBox2.Text;
            if (textBox1.Text.Length > 100)
            {
                text = textBox1.Text.Substring(0, 100);
            }
            listBox6.Items.Add("Note - " + textBox2.Text);
            textBox2.Text = "";
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
