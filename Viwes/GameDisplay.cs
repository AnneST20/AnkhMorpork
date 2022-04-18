using System;
using System.Drawing;
using System.Windows.Forms;
using AnkhMorpork.Models;
using AnkhMorpork.Controllers;
using System.IO;
using AnkhMorpork.Viwes;

namespace AnkhMorpork
{
    public partial class GameDisplay : Form
    {
        int step;
        int guildsCount;
        int currentGuild;
        int thiefMeetings;
        Inventory inventory;
        string resultOfMeeting;
        GuildController guildController;
        GuildsContext guildsContext = new GuildsContext();
        string Images = Directory.GetCurrentDirectory().Replace(@"bin\Debug", @"Images\");

        enum Guilds { Assassins, Beggars, Fools, Thieves };

        public GameDisplay()
        {
            InitializeComponent();

            step = 0;
            guildsCount = 4;
            thiefMeetings = 0;
            inventory = new Inventory() { Money = 100.00M, Beers = 0 };

            MeetGuild();
        }

        private void buttonSkip_Click(object sender, EventArgs e)
        {
            bool alive = Skip();
            if (alive) MeetGuild();
            else Die();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            bool alive = Apply();
            if (alive) MeetGuild();
            else Die();
        }
        
        private void MeetGuild()
        {
            Random random = new Random();
            string nextGuildPicturePath = Images;
            currentGuild = random.Next(guildsCount);

            numericAssassinReward.Visible = false;
            labelGold.Text = ((int)inventory.Money).ToString();
            labelSilver.Text = ((int)(inventory.Money * 100 % 100)).ToString();
            labelBeer.Text = inventory.Beers.ToString();
            labelPreviousStep.Text = resultOfMeeting;

            switch (currentGuild)
            {
                case 0:
                    nextGuildPicturePath += "Assassin.jpg";
                    guildController = new AssassinsController(guildsContext, inventory);
                    buttonMove.Text = "Resing the contract";
                    numericAssassinReward.Visible = true;
                    break;
                case 1:
                    nextGuildPicturePath += "Beggar.jpg";
                    guildController = new BeggarsController(guildsContext, inventory);
                    buttonMove.Text = "Give them money";
                    break;
                case 2:
                    nextGuildPicturePath += "Fool.jpg";
                    guildController = new FoolsController(guildsContext, inventory);
                    buttonMove.Text = "Help the fool";
                    break;
                case 3:
                    nextGuildPicturePath += "Thief.jpg";
                    if (++thiefMeetings == 6) guildsCount--;
                    guildController = new ThievesController(guildsContext, inventory);
                    buttonMove.Text = "Give him 10 AM$";
                    break;
                default: break;
            }

            pictureBoxGuild.Image = Image.FromFile(nextGuildPicturePath);
            labelStep.Text = "Step: " + ++step;
            labelGuildInfo.Text = guildController.ShowGuildInfo();
            labelMeetGuild.Text = "You meet " + Enum.GetName(typeof(Guilds), currentGuild) + "' Guild!";
        }

        private bool Apply()
        {
            if (currentGuild == 0)
            {
                guildController = new AssassinsController(guildsContext, inventory)
                { Reward = numericAssassinReward.Value };
            }

            bool alive = guildController.ApplyGuildRequest();
            resultOfMeeting = guildController.ShowMeetingResult();

            return alive;
        }

        private bool Skip()
        {
            switch (currentGuild)
            {
                
                case 2:
                    resultOfMeeting = guildController.ShowMeetingResult();
                    return true;
                default:
                    return false;
            }
        }

        private void Die()
        {
            string death = "You are dead\n";
            switch (currentGuild)
            {
                case 0:
                    death += "You failed to re-sign the contract so the assassins killed you...";
                    break;
                case 1:
                    death += "The beggars persecuted you for the rest of your life";
                    break;
                case 3:
                    death += "Uou did not give money to thief and he cut your throat...";
                    break;
                default: break;
            }

            this.Hide();
            EndGame end = new EndGame(death);
            end.Show();
        }

        private void GameDisplay_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
