# magic-sheev-ball

---

### Description: This is a silly little project I made in C# during my free time, it is a magic 8 ball with a special "sheev mode," which is a reference to the Star Wars prequels. Enjoy!

![8ball](https://github.com/EnEmerson/magic-sheev-ball/blob/master/resources/8ball.png)

```c#
namespace magicEightBall
{
    public partial class magicBallForm : Form
    {
        Image magicBall = new Bitmap(@"8ball.png");

        string[] choices = new string[]{"It is certain", "Very doubtful", "Decidedly so",
                    "Outlook not good", "Without question", "Never", "Most likely",
                    "Ask again later", "Absolutely", "Cannot tell", "Do it", "Yes" };

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
                int upperBound = choices.Length + 1;
                int decision = rand.Next(1, upperBound); // (inclusive, exclusive)
                string response = choices[decision-1];
                answerLabel.Text = response;
            }
        }
    }
}
```

### Note: The built version of this project is located in /magic-sheev-ball/magicEightBall/bin/Debug, I have included a shortcut to this file in the main folder here.