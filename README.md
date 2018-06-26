# magic-sheev-ball

---

### Description: This is a silly little project I made in C# during my free time, it is a magic 8 ball with a special "sheev mode," which is a reference to the Star Wars prequels. Enjoy!

![8ball]()

```c#
namespace magicEightBall
{
    public partial class magicBallForm : Form
    {
        Image magicBall = new Bitmap(@"8ball.png");

        public magicBallForm()
        {
            InitializeComponent();
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            if(sheevModeCheck.Checked)
            {
                Image sheev = new Bitmap(@"sheevball.png");
                this.BackgroundImage = sheev;

                answerLabel.Text = "Do it.";
            }
            else
            {
                this.BackgroundImage = magicBall;
                answerLabel.Text = "";

                int decision = rand.Next(1, 11);

                switch(decision)
                {
                    case 1: answerLabel.Text = "It is certain.";
                        break;

                    case 2: answerLabel.Text = "Very doubtful.";
                        break;

                    case 3: answerLabel.Text = "Decidedly so.";
                        break;

                    case 4: answerLabel.Text = "Outlook not good.";
                        break;

                    case 5: answerLabel.Text = "Without a doubt.";
                        break;

                    case 6: answerLabel.Text = "Never.";
                        break;

                    case 7: answerLabel.Text = "Most likely.";
                        break;

                    case 8: answerLabel.Text = "Ask again later.";
                        break;

                    case 9: answerLabel.Text = "Absolutely.";
                        break;

                    case 10: answerLabel.Text = "Cannot predict now.";
                        break;

                    default: answerLabel.Text = "Do it.";
                        break;
                }
            }
        }
    }
}
```