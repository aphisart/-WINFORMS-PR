using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gwint_prototype
{
    public partial class Form1 : Form
    {
        List<Card> deckList;
        List<Card> handList;
        List<Card> playerCloseTroops = new List<Card>();
        List<Card> playerRangeTroops = new List<Card>();
        List<Card> playerSiegeTroops = new List<Card>();
        Card selectCard;

        public Form1()
        {
            deckList = new List<Card>
            {
                 new Card("Kakashi.png", 13,"Sharingan","Hatake", "melee/range/siege"), 
                new Card("Hinata.png", 12,"Biakugan","Hiuga","melee/range/siege"), 
                new Card("Itachi.png", 13,"Sharingan","Uchiha","melee/range/siege"), 
                new Card("Naruto.png", 15,"Djinchuuriki","Uzumaki","melee/range/siege"),
                new Card("Sasuke.png", 15,"Sharingan","Uchiha","melee/range/siege"),
                new Card("Jiraiya.png", 17,"Hermit","Sannin","melee/range/siege"),
                new Card("Hiruzen.png", 15,"Shinigami","Hokage","melee/range/siege"),
                new Card("Lee.png", 12, "Thaidjutsu","Konoha","melee/range/siege"),
                new Card("Tenten.png",10,"Weapon","Konoha","melee/range/siege"),
                new Card("Orochimaru.png",14,"Snakes","Apostate","melee/range/siege"),
                new Card("Shikamaru.png",12,"Shadows","Konoha", "melee/range/siege"),
                new Card("Sakura.png",12,"Medic","Konoha","melee/range/siege"),
                new Card("Nagato.png",12,"Rinnegan","Akatsuki","melee/range/siege"),
                new Card("Tsunade.png",15,"Strenght","Hokage","melee/range/siege"),
                new Card("Minato.png",17,"Speed", "Hokage","melee/range/siege"),
                new Card("Hasirama.png",20,"Wood","Hokage","melee/range/siege"),
                new Card("Hidan.png",15,"Immortal","Akatsuki","melee/range/siege"),
                new Card("Kakuzu.png",15,"Immortal","Akatsuki","melee/range/siege"),
                new Card("Kisame.png",15,"Samehada","Akatsuki","melee/range/siege"),
                new Card("Konan.png",13,"Paper","Akatsuki","melee/range/siege"),
                new Card("Konohamaru.png",7,"Firewill","Konoha","melee/range/siege"),
                new Card("AnbuKonoha.png",10,"Ninjutsu","ANBU","melee/range/siege"),
                new Card("Asuma.png",13,"Wind","Konoha","melee/range/siege"),
                new Card("Deidara.png",13,"Explosion","Akatsuki","melee/range/siege"),
                new Card("Gamabunta.png",14,"Kvak","Frogs","melee/range/siege"),
                new Card("Gamakichi.png",10,"Kvak","Frogs","melee/range/siege"),
                new Card("Madara.png",25,"Sharingan","Uchiha","melee/range/siege"),
                new Card("Manda.png",18,"Summoned","Snake","melee/range/siege"),
                new Card("Neji.png",13,"Biakugan","Hiuga","melee/range/siege"),
                new Card("Nine.png",30,"Tails","Bijou","melee/range/siege"),
                new Card("Sai.png",14,"Paint","Anbu","melee/range/siege"),
                new Card("Sasori.png",15,"Puppets","Akatsuki","melee/range/siege"),
                new Card("Tobi.png",16,"Sharingan","Akatsuki","melee/range/siege"),
                new Card("Tobirama.png",18,"Water","Hokage","melee/range/siege"),
                new Card("Yamato.png",17,"Wood","Anbu","melee/range/siege"),
                new Card("Zetsu.png",15,"Bipolyarka","Akatsuki","melee/range/siege")
            };

            handList = new List<Card> 
            { 
                //new Card("Kakashi.png", 13,"Sharingan","Hatake", "melee/range/siege"), 
                //new Card("Hinata.png", 7,"Biakugan","Hiuga","melee/range/siege"), 
                //new Card("Itachi.png", 13,"Sharingan","Uchiha","melee/range/siege"), 
                //new Card("Naruto.png", 15,"Bijou","Uzumaki","melee/range/siege"),
                //new Card("Sasuke.png", 15,"Sharingan","Uchiha","melee/range/siege"),
                //new Card("Jiraiya.png", 17,"Hermit","Sannin","melee/range/siege"),
                //new Card("Hiruzen.png", 15,"Shinigami","Hokage","melee/range/siege"),
                //new Card("Lee.png", 12, "Thaidjutsu","Konoha","melee/range/siege"),
                //new Card("Tenten.png",10,"Weapon","Konoha","melee/range/siege"),
                //new Card("Orochimaru.png",14,"Snakes","Apostate","melee/range/siege"),
                //new Card("Shikamaru.png",12,"Shadows","Konoha", "melee/range/siege"),
                //new Card("Sakura.png",12,"Medic","Konoha","melee/range/siege")

            };
            InitializeComponent();
            FillHand();
            hand.Invalidate();
        }

        public void FillHand()
        {
            Random rand = new Random();
            for (int i = 0; i < 12; i++)
            {
                int t = rand.Next(deckList.Count);
                handList.Add(deckList[t]);
                deckList.RemoveAt(t);
            }
        }

        private void hand_Paint(object sender, PaintEventArgs e)
        {
            selectCard = null;
            for (int i = 0; i < handList.Count; i++)
            {
                handList[i].Draw(e.Graphics, i);
                if (handList[i].isClicked)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(100, 255, 255, 0)),(100+( 42+15)*i), 0, 42, 84);
                    selectCard = handList[i];
                    selectCard.pos = i;
                }  
            }
        }

        private void hand_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < handList.Count; i++)
            {
                handList[i].isClicked = false;
                if (handList[i].isMouseIn(e, i))
                    handList[i].isClicked = true;
            }
            hand.Invalidate();
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            if (selectCard != null && selectCard.type.Contains("melee") == true && playerCloseTroops.Count < 8)
            {
                playerCloseTroops.Add(handList[selectCard.pos]);
                handList.RemoveAt(selectCard.pos);
                hand.Invalidate();
            }
            playerClose.Invalidate();
            
        }

        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < playerCloseTroops.Count; i++)
            {
                {
                    playerCloseTroops[i].Draw(e.Graphics, i);
                }
            }
        }

        private void playerRange_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < playerRangeTroops.Count; i++)
            {
                {
                    playerRangeTroops[i].Draw(e.Graphics, i);
                }
            }
        }

        private void playerRange_MouseDown(object sender, MouseEventArgs e)
        {
            if (selectCard != null && selectCard.type.Contains("range") == true && playerRangeTroops.Count < 8)
            {
                playerRangeTroops.Add(handList[selectCard.pos]);
                handList.RemoveAt(selectCard.pos);
                hand.Invalidate();
            }
            playerRange.Invalidate();
        }

        private void playerSiege_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < playerSiegeTroops.Count; i++)
            {
                {
                    playerSiegeTroops[i].Draw(e.Graphics, i);
                }
            }
        }

        private void playerSiege_MouseDown(object sender, MouseEventArgs e)
        {
            if (selectCard != null && selectCard.type.Contains("siege") == true && playerRangeTroops.Count < 8)
            {
                playerSiegeTroops.Add(handList[selectCard.pos]);
                handList.RemoveAt(selectCard.pos);
                hand.Invalidate();
            }
            playerSiege.Invalidate();
        }
    }
}
