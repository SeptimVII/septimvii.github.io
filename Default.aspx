<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Quiz</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>

    <style>
    .jumbotron { background-image: url("http://localhost:50475/Img/647082_youwall-majestic-nature-wallpapers-wallpaper-wallpapers-free_1920x1200_h.jpg"); }

        .radio-inline {
            margin: 10px;
        }

        #SubmitBtn {
            margin-top: 20px;
            background-color: cornflowerblue;
        }

            #SubmitBtn:hover {
                background-color: royalblue;
            }
    </style>

</head>

<body>
    <form id="form1" runat="server">
        <div>
            <div class="container">
                <div class="row-fluid">
                    <div class="jumbotron text-center shadow-lg">
                        <h1>Spirit Animal Quiz</h1>
                        <p>Find which animal resides within you!</p>
                    </div>
                </div>
            </div>
        </div>

        <div class="container text-center">
            <h4 id="animalResult" runat="server"></h4>
            <asp:Image runat="server" ID="AnimalImg" style="margin-bottom: 10px;"/>
            <p id="resultDesc" runat="server"></p>
        </div>

        <section id="questions" runat="server">
            <div>
                <div class="container">
                    <div class="row-fluid text-center">
                        <h4>Q1. Who is most important to you?</h4>
                        <label class="radio-inline">
                            <input runat="server" id="Q1a" type="radio" name="Q1" value="5" />Family and friends</label>
                        <label class="radio-inline">
                            <input runat="server" id="Q1b" type="radio" name="Q1" value="10" />One other person</label>
                        <label class="radio-inline">
                            <input runat="server" id="Q1c" type="radio" name="Q1" value="15" />Myself</label>
                        <label class="radio-inline">
                            <input runat="server" id="Q1d" type="radio" name="Q1" value="20" />Only a select few</label>
                    </div>
                </div>
            </div>

            <div class="container">
                <hr />
            </div>

            <div>
                <div class="container">
                    <div class="row-fluid text-center">
                        <h4>Q2. What does your diet mainly consist of?</h4>
                        <label class="radio-inline">
                            <input runat="server" id="Q2a" type="radio" name="Q2" value="5" />Meat only</label>
                        <label class="radio-inline">
                            <input runat="server" id="Q2b" type="radio" name="Q2" value="10" />Veg only</label>
                        <label class="radio-inline">
                            <input runat="server" id="Q2c" type="radio" name="Q2" value="15" />Fruit and nuts mainly</label>
                        <label class="radio-inline">
                            <input runat="server" id="Q2d" type="radio" name="Q2" value="20" />A mix of meat and veg</label>
                    </div>
                </div>
            </div>

            <div class="container">
                <hr />
            </div>

            <div>
                <div class="container">
                    <div class="row-fluid text-center">
                        <h4>Q3. Where is your preferred holiday location?</h4>
                        <label class="radio-inline">
                            <input runat="server" id="Q3a" type="radio" name="Q3" value="5" />Open grassland</label>
                        <label class="radio-inline">
                            <input runat="server" id="Q3b" type="radio" name="Q3" value="10" />Dry desert</label>
                        <label class="radio-inline">
                            <input runat="server" id="Q3c" type="radio" name="Q3" value="15" />Near the ocean</label>
                        <label class="radio-inline">
                            <input runat="server" id="Q3d" type="radio" name="Q3" value="20" />Dense Jungle</label>
                    </div>
                </div>
            </div>

            <div class="container">
                <hr />
            </div>

            <div>
                <div class="container">
                    <div class="row-fluid text-center">
                        <h4>Q4. What is your favourite colour?</h4>
                        <label class="radio-inline">
                            <input runat="server" id="Q4a" type="radio" name="Q4" value="5" />Red</label>
                        <label class="radio-inline">
                            <input runat="server" id="Q4b" type="radio" name="Q4" value="10" />Green</label>
                        <label class="radio-inline">
                            <input runat="server" id="Q4c" type="radio" name="Q4" value="15" />Yellow</label>
                        <label class="radio-inline">
                            <input runat="server" id="Q4d" type="radio" name="Q4" value="20" />Blue</label>
                    </div>
                </div>
            </div>

            <div class="container">
                <hr />
            </div>

            <div>
                <div class="container">
                    <div class="row-fluid text-center">
                        <h4>Q5. Which of these traits seem most appealing to you?</h4>
                        <label class="radio-inline">
                            <input runat="server" id="Q5a" type="radio" name="Q5" value="5" />Speed</label>
                        <label class="radio-inline">
                            <input runat="server" id="Q5b" type="radio" name="Q5" value="10" />Strength</label>
                        <label class="radio-inline">
                            <input runat="server" id="Q5c" type="radio" name="Q5" value="15" />Camouflage</label>
                        <label class="radio-inline">
                            <input runat="server" id="Q5d" type="radio" name="Q5" value="20" />Flight</label>
                    </div>
                </div>
            </div>

            <div>
                <div class="container">
                    <div class="row-fluid text-center">
                        <asp:Button runat="server" ID="SubmitBtn" CssClass="btn btn-lg" Text="Submit" OnClick="SubmitBtn_Click" />
                    </div>
                </div>
            </div>
        </section>
    </form>
</body>
</html>
