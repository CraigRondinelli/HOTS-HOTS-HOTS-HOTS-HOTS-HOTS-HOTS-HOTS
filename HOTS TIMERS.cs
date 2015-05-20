using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTS_HOTS_HOTS_HOTS_HOTS_HOTS_HOTS_HOTS
{
    public partial class HOTS_TIMERS : Form
    {
        public HOTS_TIMERS()
        {
            InitializeComponent();
            this.Text = "PAPACHIP'S SUPER SEXY HOTS TIMER™";
            AlwaysTop_Timer.Start();
        }

        private void AlwaysTop_Timer_Tick(object sender, EventArgs e)
        {
            TopMost = true;
        }
        
        //BLACKHEART'S BAY START

        private void btnFirstChest_Click(object sender, EventArgs e)
        {
            FirstChest_Progress.Value = 0;
            FirstChest_Timer.Start();
        }

        private void FirstChest_Timer_Tick(object sender, EventArgs e)
        {
            if (FirstChest_Progress.Value <= 49)
                FirstChest_Progress.Value = FirstChest_Progress.Value + 1;
            else
                FirstChest_Timer.Stop();
        }

        private void btnDoubloonCamp_Click(object sender, EventArgs e)
        {
            DoubloonCamp_Progress.Value = 0;
            DoubloonCamp_Timer.Start();
        }

        private void DoubloonCamp_Timer_Tick(object sender, EventArgs e)
        {
            if (DoubloonCamp_Progress.Value <= 149)
                DoubloonCamp_Progress.Value = DoubloonCamp_Progress.Value + 1;
            else
                DoubloonCamp_Timer.Stop();
        }

        private void btnFirstMerc_Blackheart_Click(object sender, EventArgs e)
        {
            FirstMerc_Progress_Blackheart.Value = 0;
            FirstMerc_Timer_Blackheart.Start();

        }

        private void FirstMerc_Timer_Blackheart_Tick(object sender, EventArgs e)
        {
            if (FirstMerc_Progress_Blackheart.Value <= 119)
                FirstMerc_Progress_Blackheart.Value = FirstMerc_Progress_Blackheart.Value + 1;
            else
                FirstMerc_Timer_Blackheart.Stop();
        }

        private void btnBruiser_Blackheart_Click(object sender, EventArgs e)
        {
            Bruiser_Progress_Blackheart.Value = 0;
            BruiserRespawn_Timer_Blackheart.Start();
        }

        private void BruiserRespawn_Timer_Tick(object sender, EventArgs e)
        {
            if (Bruiser_Progress_Blackheart.Value <= 239)
                Bruiser_Progress_Blackheart.Value = Bruiser_Progress_Blackheart.Value + 1;
            else
                BruiserRespawn_Timer_Blackheart.Stop();
        }

        private void btnSiege_Blackheart_Click(object sender, EventArgs e)
        {
            Siege_Progress_Blackheart.Value = 0;
            SiegeRespawn_Timer_Blackheart.Start();
        }

        private void SiegeRespawn_Timer_Tick(object sender, EventArgs e)
        {
            if (Siege_Progress_Blackheart.Value <= 179)
                Siege_Progress_Blackheart.Value = Siege_Progress_Blackheart.Value + 1;
            else
                SiegeRespawn_Timer_Blackheart.Stop();
        }

        private void btnBoss_Blackheart_Click(object sender, EventArgs e)
        {
            Boss_Progress_Blackheart.Value = 0;
            BossRespawn_Timer_Blackheart.Start();
        }

        private void BossRespawn_Timer_Blackheart_Tick(object sender, EventArgs e)
        {
            if (Boss_Progress_Blackheart.Value <= 299)
                Boss_Progress_Blackheart.Value = Boss_Progress_Blackheart.Value + 1;
            else
                BossRespawn_Timer_Blackheart.Stop();
        }

        //BLACKHEART'S BAY END

        //CURSED HOLLOW START

        private void btnFirstMercs_Cursed_Click(object sender, EventArgs e)
        {
            FirstMercs_Progress_Cursed.Value = 0;
            FirstMercs_Timer_Cursed.Start();
        }

        private void FirstMercs_Timer_Cursed_Tick(object sender, EventArgs e)
        {
            if (FirstMercs_Progress_Cursed.Value <= 119)
                FirstMercs_Progress_Cursed.Value = FirstMercs_Progress_Cursed.Value + 1;
            else
                FirstMercs_Timer_Cursed.Stop();
        }

        private void btnBruiser_Cursed_Click(object sender, EventArgs e)
        {
            BruiserRespawn_Progress_Cursed.Value = 0;
            BruiserRespawn_Timer_Cursed.Start();
        }

        private void BruiserRespawn_Timer_Cursed_Tick(object sender, EventArgs e)
        {
            if (BruiserRespawn_Progress_Cursed.Value <= 239)
                BruiserRespawn_Progress_Cursed.Value = BruiserRespawn_Progress_Cursed.Value + 1;
            else
                BruiserRespawn_Timer_Cursed.Stop();
        }

        private void btnSiege_Cursed_Click(object sender, EventArgs e)
        {
            SiegeRespawn_Progress_Cursed.Value = 0;
            SiegeRespawn_Timer_Cursed.Start();
        }

        private void SiegeRespawn_Timer_Cursed_Tick(object sender, EventArgs e)
        {
            if (SiegeRespawn_Progress_Cursed.Value <= 179)
                SiegeRespawn_Progress_Cursed.Value = SiegeRespawn_Progress_Cursed.Value + 1;
            else
                SiegeRespawn_Timer_Cursed.Stop();
        }

        private void btnBoss_Cursed_Click(object sender, EventArgs e)
        {
            BossRespawn_Progress_Cursed.Value = 0;
            BossRespawn_Timer_Cursed.Start();
        }

        private void BossRespawn_Timer_Cursed_Tick(object sender, EventArgs e)
        {
            if (BossRespawn_Progress_Cursed.Value <= 299)
                BossRespawn_Progress_Cursed.Value = BossRespawn_Progress_Cursed.Value + 1;
            else
                BossRespawn_Timer_Cursed.Stop();
        }

        //CURSED HOLLOW END

        //DRAGONSHRINE START

        private void btnFirstShrine_Click(object sender, EventArgs e)
        {
            FirstShrine_Progress.Value = 0;
            FirstShrine_Timer.Start();
        }

        private void FirstShrine_Timer_Tick(object sender, EventArgs e)
        {
            if (FirstShrine_Progress.Value <= 74)
                FirstShrine_Progress.Value = FirstShrine_Progress.Value + 1;
            else
                FirstShrine_Timer.Stop();
        }

        private void btnNextShrines_Click(object sender, EventArgs e)
        {
            NextShrine_Progress.Value = 0;
            NextShrines_Timer.Start();
        }

        private void NextShrines_Timer_Tick(object sender, EventArgs e)
        {
            if (NextShrine_Progress.Value <= 119)
                NextShrine_Progress.Value = NextShrine_Progress.Value + 1;
            else
                NextShrines_Timer.Stop();
        }

        private void btnFirstMercs_Dragon_Click(object sender, EventArgs e)
        {
            FirstMercs_Progress_Dragon.Value = 0;
            FirstMercs_Timer_Dragon.Start();
        }

        private void FirstMercs_Timer_Dragon_Tick(object sender, EventArgs e)
        {
            if (FirstMercs_Progress_Dragon.Value <= 119)
                FirstMercs_Progress_Dragon.Value = FirstMercs_Progress_Dragon.Value + 1;
            else
                FirstMercs_Timer_Dragon.Stop();
        }

        private void btnBruiserRespawn_Dragon_Click(object sender, EventArgs e)
        {
            BruiserRespawn_Progress_Dragon.Value = 0;
            BruiserRespawn_Timer_Dragon.Start();
        }

        private void BruiserRespawn_Timer_Dragon_Tick(object sender, EventArgs e)
        {
            if (BruiserRespawn_Progress_Dragon.Value <= 239)
                BruiserRespawn_Progress_Dragon.Value = BruiserRespawn_Progress_Dragon.Value + 1;
            else
                BruiserRespawn_Timer_Dragon.Stop();
        }

        private void btnSiegeRespawn_Dragon_Click(object sender, EventArgs e)
        {
            SiegeRespawn_Progress_Dragon.Value = 0;
            SiegeRespawn_Timer_Dragon.Start();
        }

        private void SiegeRespawn_Timer_Dragon_Tick(object sender, EventArgs e)
        {
            if (SiegeRespawn_Progress_Dragon.Value <= 179)
                SiegeRespawn_Progress_Dragon.Value = SiegeRespawn_Progress_Dragon.Value + 1;
            else
                SiegeRespawn_Timer_Dragon.Stop();
        }

        //DRAGONSHRINE END

        //GARDEN START

        private void btnFirstNight_Click(object sender, EventArgs e)
        {
            FirstNight_Progress.Value = 0;
            FirstNight_Timer.Start();
        }

        private void FirstNight_Timer_Tick(object sender, EventArgs e)
        {
            if (FirstNight_Progress.Value <= 89)
                FirstNight_Progress.Value = FirstNight_Progress.Value + 1;
            else
                FirstNight_Timer.Stop();
        }

        private void btnNextNight_Click(object sender, EventArgs e)
        {
            NextNight_Progress.Value = 0;
            NextNight_Timer.Start();
        }

        private void NextNight_Timer_Tick(object sender, EventArgs e)
        {
            if (NextNight_Progress.Value <= 199)
                NextNight_Progress.Value = NextNight_Progress.Value + 1;
            else
                NextNight_Timer.Stop();
        }

        private void btnFirstMercs_Garden_Click(object sender, EventArgs e)
        {
            FirstMercs_Progress_Garden.Value = 0;
            FirstMercs_Timer_Garden.Start();
        }

        private void FirstMercs_Timer_Garden_Tick(object sender, EventArgs e)
        {
            if (FirstMercs_Progress_Garden.Value <= 119)
                FirstMercs_Progress_Garden.Value = FirstMercs_Progress_Garden.Value + 1;
            else
                FirstMercs_Timer_Garden.Stop();
        }

        private void btnBruiserRespawn_Garden_Click(object sender, EventArgs e)
        {
            BruiserRespawn_Progress_Garden.Value = 0;
            BruiserRespawn_Timer_Garden.Start();
        }

        private void BruiserRespawn_Timer_Garden_Tick(object sender, EventArgs e)
        {
            if (BruiserRespawn_Progress_Garden.Value <= 239)
                BruiserRespawn_Progress_Garden.Value = BruiserRespawn_Progress_Garden.Value + 1;
            else
                BruiserRespawn_Timer_Garden.Stop();
        }

        private void btnSiegeRespawn_Garden_Click(object sender, EventArgs e)
        {
            SiegeRespawn_Progress_Garden.Value = 0;
            SiegeRespawn_Timer_Garden.Start();
        }

        private void SiegeRespawn_Timer_Garden_Tick(object sender, EventArgs e)
        {
            if (SiegeRespawn_Progress_Garden.Value <= 179)
                SiegeRespawn_Progress_Garden.Value = SiegeRespawn_Progress_Garden.Value + 1;
            else
                SiegeRespawn_Timer_Garden.Stop();
        }

        //GARDEN END

        //HAUNTED MINES START

        private void btnFirstMines_Click(object sender, EventArgs e)
        {
            FirstMines_Progress.Value = 0;
            FirstMines_Timer.Start();
        }

        private void FirstMines_Timer_Tick(object sender, EventArgs e)
        {
            if (FirstMines_Progress.Value <= 119)
                FirstMines_Progress.Value = FirstMines_Progress.Value + 1;
            else
                FirstMines_Timer.Stop();
        }

        private void btnNextMines_Click(object sender, EventArgs e)
        {
            NextMines_Progress.Value = 0;
            NextMines_Timer.Start();
        }

        private void NextMines_Timer_Tick(object sender, EventArgs e)
        {
            if (NextMines_Progress.Value <= 119)
                NextMines_Progress.Value = NextMines_Progress.Value + 1;
            else
                NextMines_Timer.Stop();
        }

        private void btnFirstMercs_Mines_Click(object sender, EventArgs e)
        {
            FirstMercs_Progress_Mines.Value = 0;
            FirstMercs_Timer_Mines.Start();
        }

        private void FirstMercs_Timer_Mines_Tick(object sender, EventArgs e)
        {
            if (FirstMercs_Progress_Mines.Value <= 119)
                FirstMercs_Progress_Mines.Value = FirstMercs_Progress_Mines.Value + 1;
            else
                FirstMercs_Timer_Mines.Stop();
        }

        private void btnBruiserRespawn_Mines_Click(object sender, EventArgs e)
        {
            BruiserRespawn_Progress_Mines.Value = 0;
            BruiserRespawn_Timer_Mines.Start();
        }

        private void BruiserRespawn_Timer_Mines_Tick(object sender, EventArgs e)
        {
            if (BruiserRespawn_Progress_Mines.Value <= 239)
                BruiserRespawn_Progress_Mines.Value = BruiserRespawn_Progress_Mines.Value + 1;
            else
                BruiserRespawn_Timer_Mines.Stop();
        }

        private void btnSiegeRespawn_Mines_Click(object sender, EventArgs e)
        {
            SiegeRespawn_Progress_Mines.Value = 0;
            SiegeRespawn_Timer_Mines.Start();
        }

        private void SiegeRespawn_Timer_Mines_Tick(object sender, EventArgs e)
        {
            if (SiegeRespawn_Progress_Mines.Value <= 179)
                SiegeRespawn_Progress_Mines.Value = SiegeRespawn_Progress_Mines.Value + 1;
            else
                SiegeRespawn_Timer_Mines.Stop();
        }

        //HAUNTED MINES END

        //SKY TEMPLE START

        private void btnFirstTemples_Click(object sender, EventArgs e)
        {
            FirstTemples_Progress.Value = 0;
            FirstTemple_Timer.Start();
        }

        private void FirstTemple_Timer_Tick(object sender, EventArgs e)
        {
            if (FirstTemples_Progress.Value <= 89)
                FirstTemples_Progress.Value = FirstTemples_Progress.Value + 1;
            else
                FirstTemple_Timer.Stop();
        }

        private void btnNextTemples_Click(object sender, EventArgs e)
        {
            NextTemples_Progress.Value = 0;
            NextTemple_Timer.Start();
        }

        private void NextTemple_Timer_Tick(object sender, EventArgs e)
        {
            if (NextTemples_Progress.Value <= 119)
                NextTemples_Progress.Value = NextTemples_Progress.Value + 1;
            else
                NextTemple_Timer.Stop();
        }

        private void btnFirstMercs_Temple_Click(object sender, EventArgs e)
        {
            FirstMercs_Progress_Temple.Value = 0;
            FirstMercs_Timer_Temple.Start();
        }

        private void FirstMercs_Timer_Temple_Tick(object sender, EventArgs e)
        {
            if (FirstMercs_Progress_Temple.Value <= 119)
                FirstMercs_Progress_Temple.Value = FirstMercs_Progress_Temple.Value + 1;
            else
                FirstMercs_Timer_Temple.Stop();
        }

        private void btnBruiserRespawn_Temple_Click(object sender, EventArgs e)
        {
            BruiserRespawn_Progress_Temple.Value = 0;
            BruiserRespawn_Timer_Temple.Start();
        }

        private void BruiserRespawn_Timer_Temple_Tick(object sender, EventArgs e)
        {
            if (BruiserRespawn_Progress_Temple.Value <= 239)
                BruiserRespawn_Progress_Temple.Value = BruiserRespawn_Progress_Temple.Value + 1;
            else
                BruiserRespawn_Timer_Temple.Stop();
        }

        private void btnSiegeRespawn_Temple_Click(object sender, EventArgs e)
        {
            SiegeRespawn_Progress_Temple.Value = 0;
            SiegeRespawn_Timer_Temple.Start();
        }

        private void SiegeRespawn_Timer_Temple_Tick(object sender, EventArgs e)
        {
            if (SiegeRespawn_Progress_Temple.Value <= 179)
                SiegeRespawn_Progress_Temple.Value = SiegeRespawn_Progress_Temple.Value + 1;
            else
                SiegeRespawn_Timer_Temple.Stop();
        }

        private void btnBossRespawn_Temple_Click(object sender, EventArgs e)
        {
            BossRespawn_Progress_Temple.Value = 0;
            BossRespawn_Timer_Temple.Start();
        }

        private void BossRespawn_Timer_Temple_Tick(object sender, EventArgs e)
        {
            if (BossRespawn_Progress_Temple.Value <= 299)
                BossRespawn_Progress_Temple.Value = BossRespawn_Progress_Temple.Value + 1;
            else
                BossRespawn_Timer_Temple.Stop();
        }
        
        //SKY TEMPLE END

            //TO DO
                //1. add sounds
                //2. come up with better way to handle starting timers
                //3. probably add text to progress bars
    }
}
