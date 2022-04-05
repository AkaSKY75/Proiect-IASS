<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Proiect.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <link href="//netdna.bootstrapcdn.com/font-awesome/3.2.1/css/font-awesome.css" rel="stylesheet">

    <title>
        Formular
    </title>
    <h3>
        <center>Completeaza formularul</center>
       
    </h3>
    <h7>
        <center>Completeaza formularul acordand o nota pe scara de apreciere de la Foarte nemultumit (1) la Foarte multumit (6). Toate intrebarile sunt obligatorii</center>
    </h7>
</head>
<body>
    <div>
        <p>

        </p>
        <p>

        </p>
    </div>
    <form id="form1" runat="server">

    </form>
    <div id="questions">
        
    </div>
        <div class="mx-0 mx-sm-auto">
  <div class="card">
    <div class="card-body">


      <form class="px-2" action="">
        <p class="text-center"><strong>Cum ne evaluezi formularul:</strong></p>

        <ul  class="h2 rating justify-content-center pb-3" data-mdb-toggle="rating">
            <center>
          <li style="display:inline">
            <i class="far fa-star fa-sm text-primary" title="Bad"></i>
          </li>
          <li style="display:inline">
            <i class="far fa-star fa-sm text-primary" title="Poor"></i>
          </li>
          <li style="display:inline">
            <i class="far fa-star fa-sm text-primary" title="OK"></i>
          </li>
          <li style="display:inline">
            <i class="far fa-star fa-sm text-primary" title="Good"></i>
          </li>
          <li style="display:inline">
            <i class="far fa-star fa-sm text-primary" title="Excellent"></i>
          </li>
                </center>
        </ul>

        <p class="text-center"><strong>Ce putem imbunatati?</strong></p>

        <!-- Message input -->
        <div class="form-outline mb-4 row">
           <div class="col-6 mx-auto">
          <textarea  class="form-control" id="form3Example4" rows="2"></textarea>
          <label class="form-label" for="form4Example6">Your feedback</label>
            </div>
        </div>
      </form>
    </div>
    <div class="card-footer text-end">
      <button type="button" class="btn btn-primary">Submit</button>
    </div>
  </div>
</div>
</body>
    <script src="https://kit.fontawesome.com/811cf9ba4c.js" crossorigin="anonymous"></script>
    <script>
        var questions = ['Cat de multumit(a) ai fost de intreaga experienta avuta referitoare la aceasta vizita (incepand cu experienta in receptie si in cabinet si pana la efectuarea platii)?', 'Cum ai perceput atmosfera si aspectul general al receptiei si al zonei de asteptare cu ocazia acestei vizite?', 'Cat de clare, corecte si complete au fost informatiile furnizate de colegii din receptie?', 'Cat de multumit ai fost de implicarea si profesionalismul medicului in evaluare, diagnostic si tratamentul recomandat?', 'Cum evaluezi amabilitatea si atentia acordate de catre asistentul medical pe parcursul consultatiei/efectuarii manevrelor medicale?', 'Avand in vedere contextul COVID 19, te-ai simtit in siguranta in timpul intregii vizite la noi?','Cat de probabil este sa recomanzi serviciile noastre catre prieteni sau familie'];
        for (var i = 0; i < questions.length; i++) {
            var div = document.createElement('div');
            div.className = "text-center mb-3";
            div.innerHTML = '<div class="d-inline mx-3">Foarte nemultumit</div ><div class="form-check form-check-inline"><input class="form-check-input" type="radio" name="inlineRadioOptions ' + i + ' " id="inlineRadio1_' + i + '" value="option1" /><label class="form-check-label" for="inlineRadio1_' + i + ' ">1</label></div><div class="form-check form-check-inline"><input class="form-check-input" type="radio" name="inlineRadioOptions ' + i + ' " id="inlineRadio2_' + i + '" value="option2" /><label class="form-check-label" for="inlineRadio2">2</label></div><div class="form-check form-check-inline"><input class="form-check-input" type="radio" name="inlineRadioOptions ' + i + '" id="inlineRadio3_' + i + '" value="option3" /><label class="form-check-label" for="inlineRadio3_' + i + '">3</label></div><div class="form-check form-check-inline"><input class="form-check-input" type="radio" name="inlineRadioOptions ' + i + ' " id="inlineRadio4_' + i + '"value="option4" /><label class="form-check-label" for="inlineRadio4_' + i + '">4</label></div><div class="form-check form-check-inline"><input class="form-check-input" type="radio" name="inlineRadioOptions ' + i + ' " id="inlineRadio5_' + i + '" value="option5" /><label class="form-check-label" for="inlineRadio5_' + i + '">5</label></div><div class="form-check form-check-inline"><input class="form-check-input" type="radio" name="inlineRadioOptions ' + i + ' " id="inlineRadio6_' + i + '"value="option6" /><label class="form-check-label" for="inlineRadio6_' + i + '">6</label></div><div class="d-inline me-4">Foarte multumit</div>'
       // document.querySelector("body").appendChild(div);
            var div_child = document.createElement('div');
            div_child.className = "text-center";

            div_child.innerHTML = ' <div class="text-center"><p><strong> ' + questions[i] + '</strong></p></div >';
            document.getElementById("questions").appendChild(div_child);
            document.getElementById("questions").appendChild(div);
        }

    </script>

</html>
