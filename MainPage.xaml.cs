
namespace TDMPW_412_3P_PR01;

public partial class MainPage : ContentPage
{

    string quest = "";
    int random;
    int strike = 0;
    int score = 0;
    int noAsk = 0;

    public MainPage()
	{
		InitializeComponent();

        ShowQuest();
        ChooseImg();
	}


    List<bool> noRept = new List<bool>()
    {
        false,         
        false,
        false, 
        false, 
        false, 
        false,
        false,
        false,
        false,
        false
    };

    List<string> questions = new List<string>()
    {
        "Que grupo de kpop se formó del reality show 'I-land'?",

        "Que grupo de kpop se formó del reality show 'Produce 48'?",

        "Que grupo de kpop se formó del reality show 'Produce 101' ?",

        "Que grupo de kpop tiene 13 integrantes?",

        "Que grupo de kpop fue el primero en ganar un premio Billboard?",

        "Que artista debutó más de 5 veces y en más de 2 empresas diferentes?",

        "Que grupo tiene un lighstick con una corona amarilla?",

        "Que grupo de kpop se formó en la empresa de G-Friend después de su desintegración?",

        "Que grupo de kpop se formó del reality show llamado 'Sixteen'?",

        "Cuál es el nombre de la hermana de Chaeryeong de Itzy?"
    };

    private void NextQuest()
    {

        if (noAsk == 5)
        {
            lblCong.Text = "GAME OVER";
            lblCong.Opacity = 100;
        }
        else
        {
            lblCong.Opacity = 0;
            btnNext.Opacity = 0;
            ShowQuest();
            ChooseImg();
            txtAnswer.Text = "";
            strike = 0;
            img1.Opacity = 100;
            img2.Opacity = 100;
        }
     
    }

    private void PicQuest()
    {
        random = new Random().Next(0, questions.Count);

        if (noRept[random] == true)
        {
            PicQuest();
        }
 
        quest = questions[random];
        
      
    }

    private void ShowQuest()
    {
        PicQuest();


        lblQuest.Text = quest;
        noAsk++;
        noRep();
    }

    private void ChooseImg()
    {
        if (random == 0)
        {
            imgChoose.Source = "il.jpg";
        }
        else if (random == 1)
        {
            imgChoose.Source = "cuatro.jpeg";
        }
        else if (random == 2)
        {
            imgChoose.Source = "cien.jpg";
        }
        else if (random == 3)
        {
            imgChoose.Source = "sv.jpg";
        }
        else if (random == 4)
        {
            imgChoose.Source = "bil.jpg";
        }
        else if (random == 5)
        {
            imgChoose.Source = "hy.jpg";
        }
        else if (random == 6)
        {
            imgChoose.Source = "bb.jpg";
        }
        else if (random == 7)
        {
            imgChoose.Source = "ls.jpg";
        }
        else if (random == 8)
        {
            imgChoose.Source = "six.jpg";
        }
        else if (random == 9)
        {
            imgChoose.Source = "cha.jpg";
        }
    }

    List<string> answers = new List<string>()
    {
        "Enhypen",
        "Iz*one",
        "I.O.I",
        "Seventeen",
        "Bts",
        "Hyuna",
        "Bigbang",
        "Le Sserafim",
        "Twice",
        "Chaeyeon"
    };

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (txtAnswer.Text.ToUpper() == answers[random].ToUpper())
        {
            score++;
            lblNo.Text = score.ToString();

            if(score == 3)
            {
                lblCong.Text = "GANASTE!!";
                lblCong.Opacity = 100;
            }
            else
            {
                btnNext.Opacity = 100;
                lblCong.Opacity = 100;

            }
        }
        else
        {
            strike++;

            Strike();

            if (strike == 2)
            {
                NextQuest();
            }

        }
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        NextQuest();
       
    }

    private void Strike()
    {
        if (strike == 1)
        {
            img2.Opacity = 0;
        }
        else if(strike == 2)
        {
            img1.Opacity = 0;
        }

    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        noAsk = 0;
        score = 0;
        lblNo.Text = score.ToString();

        for(int i = 0; i<10; i++)
        {
            noRept[i] = false;
        }

        NextQuest();
    }

    private void noRep()
    {
        noRept[random] = true;
    }
}

