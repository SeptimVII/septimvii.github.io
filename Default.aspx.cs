using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    public static int score = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Q1a.Checked = true;
            Q2a.Checked = true;
            Q3a.Checked = true;
            Q4a.Checked = true;
            Q5a.Checked = true;

            AnimalImg.Visible = false;
        }
    }

    protected void SubmitBtn_Click(object sender, EventArgs e)
    {
        CalcScore();
        questions.Visible = false;

        if (score >= 25 && score < 35)
        {
            animalResult.InnerText = "The Deer";
            resultDesc.InnerText = "The deer is a symbol of tranquility and grace. You are gentle person, highly sensitive and have a strong intuition.";
            AnimalImg.ImageUrl = "http://localhost:50475/Img/140157656-612x612.jpg";
            AnimalImg.Visible = true;
        }
        else if (score >= 35 && score < 45)
        {
            animalResult.InnerText = "The Wolf";
            resultDesc.InnerText = "The Wolf is a symbol of intelligence and instinct. You have a deep connection to your own instincts and a sharp wit for what comes ahead.";
            AnimalImg.ImageUrl = "http://localhost:50475/Img/ulv_8.jpg";
            AnimalImg.Visible = true;
        }
        else if (score >= 45 && score < 55)
        {
            animalResult.InnerText = "The Eagle";
            resultDesc.InnerText = "The Eagle is a symbol of hope and courage. You have the ability to look inside yourself and know what you stand for. You work harder every day for a brighter future.";
            AnimalImg.ImageUrl = "http://localhost:50475/Img/44238099001_5301282803001_5301277623001-vs.jpg";
            AnimalImg.Visible = true;
        }
        else if (score >= 55 && score < 65)
        {
            animalResult.InnerText = "The Butterfly";
            resultDesc.InnerText = "The Butterfly is a symbol of personal transformation. You understand that life comes in many forms and is constantly moving forward, and that this is reflected in all life";
            AnimalImg.ImageUrl = "http://localhost:50475/Img/monarch-blue-sky-zinnia-linda-konz.jpg";
            AnimalImg.Visible = true;
        }
        else if (score >= 65 && score < 75)
        {
            animalResult.InnerText = "The Fox";
            resultDesc.InnerText = "The Fox is a symbol of cunningness and awareness. You take quick action to any situation and use your intellect to find the best possible solution.";
            AnimalImg.ImageUrl = "http://localhost:50475/Img/fox-laurie-campbell.jpg";
            AnimalImg.Visible = true;
        }
        else if (score >= 75 && score < 85)
        {
            animalResult.InnerText = "The Swan";
            resultDesc.InnerText = "The Swan is a symbol of inner beauty and love. You know your inner worth and you try to seek the best in the people you meet.";
            AnimalImg.ImageUrl = "http://localhost:50475/Img/swans.jpg";
            AnimalImg.Visible = true;
        }
        else if (score >= 85 && score < 95)
        {
            animalResult.InnerText = "The Panda";
            resultDesc.InnerText = "The Panda is a symbol of inner strength and peace. You feel safe and grounded in life, and have strong emotions which you can be proud of.";
            AnimalImg.ImageUrl = "http://localhost:50475/Img/_103498021_gettyimages-475636556.jpg";
            AnimalImg.Visible = true;
        }
        else if (score >= 95)
        {
            animalResult.InnerText = "The Dog";
            resultDesc.InnerText = "The Dog is a symbol of loyalty and unconditional love. You will always stand by those closest to you, and nothing could stand between you as you loyalty knows no bounds.";
            AnimalImg.ImageUrl = "http://localhost:50475/Img/Golden-Retriever.jpg";
            AnimalImg.Visible = true;
        }

        score = 0;
    }

    private void CalcScore()
    {
        if (Q1a.Checked)
        {
            score += Convert.ToInt32(Q1a.Value);
        }

        if (Q1b.Checked)
        {
            score += Convert.ToInt32(Q1b.Value);
        }

        if (Q1c.Checked)
        {
            score += Convert.ToInt32(Q1c.Value);
        }

        if (Q1d.Checked)
        {
            score += Convert.ToInt32(Q1d.Value);
        }

        ///////////////////////////////////////////

        if (Q2a.Checked)
        {
            score += Convert.ToInt32(Q2a.Value);
        }

        if (Q2b.Checked)
        {
            score += Convert.ToInt32(Q2b.Value);
        }

        if (Q2c.Checked)
        {
            score += Convert.ToInt32(Q2c.Value);
        }

        if (Q2d.Checked)
        {
            score += Convert.ToInt32(Q2d.Value);
        }

        ////////////////////////////////////////////

        if (Q3a.Checked)
        {
            score += Convert.ToInt32(Q3a.Value);
        }

        if (Q3b.Checked)
        {
            score += Convert.ToInt32(Q3b.Value);
        }

        if (Q3c.Checked)
        {
            score += Convert.ToInt32(Q3c.Value);
        }

        if (Q3d.Checked)
        {
            score += Convert.ToInt32(Q3d.Value);
        }

        //////////////////////////////////////////

        if (Q4a.Checked)
        {
            score += Convert.ToInt32(Q4a.Value);
        }

        if (Q4b.Checked)
        {
            score += Convert.ToInt32(Q4b.Value);
        }

        if (Q4c.Checked)
        {
            score += Convert.ToInt32(Q4c.Value);
        }

        if (Q4d.Checked)
        {
            score += Convert.ToInt32(Q4d.Value);
        }

        /////////////////////////////////////////////

        if (Q5a.Checked)
        {
            score += Convert.ToInt32(Q5a.Value);
        }

        if (Q5b.Checked)
        {
            score += Convert.ToInt32(Q5b.Value);
        }

        if (Q5c.Checked)
        {
            score += Convert.ToInt32(Q5c.Value);
        }

        if (Q5d.Checked)
        {
            score += Convert.ToInt32(Q5d.Value);
        }
    }
}