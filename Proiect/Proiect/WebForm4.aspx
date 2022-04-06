<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="Proiect.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="questions" style="background-color: rgba(255, 255, 255, 0.7)">
     <h3>
        <center style="font-style:italic">Completează formularul</center>
       
    </h3>
    <h7>
        <center>Completeaza formularul acordând o notă pe scara de apreciere de la Foarte nemultumiț (1) la Foarte mulțumit (6).<span style="color:red; font-weight:bold"> Toate intrebările sunt obligatorii!</span></center>
        <pre>  </pre>
        <pre>  </pre>
    </h7>
   
    </div>
        <div class="mx-0 mx-sm-auto">
  <div class="card">
    <div class="card-body">


     
        <p class="text-center"><strong>Cum ne evaluezi formularul sau ce putem îmbunătăți?</strong></p>


        <!-- Message input -->
        <div class="form-outline mb-4 row">
           <div class="col-6 mx-auto">
          <textarea name="feedback" class="form-control" id="form3Example4" rows="4" style="border-width:medium;border-color:black"></textarea>
          <label class="form-label" for="form4Example6">Feedbackul tău</label>
            </div>
        </div>
    </div>
    <div class="card-footer text-end">
        <asp:Button ID="btnsubmit" runat="server" Text="Trimite" CssClass="btn btn-primary" OnClick="btnsubmit_Click" />
    </div>
  </div>
</div>
    <script src="https://kit.fontawesome.com/811cf9ba4c.js" crossorigin="anonymous"></script>
    <script>
        var questions = ['Cât de mulțumit(ă) ai fost de întreaga experiență avută referitoare la această vizită (începand cu experiența în recepție și în cabinet și până la efectuarea plății)?', 'Cum ai perceput atmosfera și aspectul general al recepției și al zonei de așteptare cu ocazia acestei vizite?', 'Căt de clare, corecte și complete au fost informațiile furnizate de colegii din receptie?', 'Căt de multumit ai fost de implicarea și profesionalismul medicului în evaluare, diagnostic si tratamentul recomandat?', 'Cum evaluezi amabilitatea și atenția acordate de către asistentul medical pe parcursul consultatiei/efectuarii manevrelor medicale?', 'Având în vedere contextul COVID 19, te-ai simțit în siguranță în timpul întregii vizite la noi?','Cât de probabil este să recomanzi serviciile noastre către prieteni sau familie?'];
        for (var i = 0; i < questions.length; i++) {
            var div = document.createElement('div');
            div.className = "text-center mb-3";
            div.innerHTML = '<div class="d-inline mx-3" style="color:red; font-weight:bold">Foarte nemultumit</div ><div class="form-check form-check-inline"><input class="form-check-input" type="radio" name="inlineRadioOptions ' + i + ' " id="inlineRadio1_' + i + '" value="option1" /><label class="form-check-label" for="inlineRadio1_' + i + ' ">1</label></div><div class="form-check form-check-inline"><input class="form-check-input" type="radio" name="inlineRadioOptions ' + i + ' " id="inlineRadio2_' + i + '" value="option2" /><label class="form-check-label" for="inlineRadio2">2</label></div><div class="form-check form-check-inline"><input class="form-check-input" type="radio" name="inlineRadioOptions ' + i + '" id="inlineRadio3_' + i + '" value="option3" /><label class="form-check-label" for="inlineRadio3_' + i + '">3</label></div><div class="form-check form-check-inline"><input class="form-check-input" type="radio" name="inlineRadioOptions ' + i + ' " id="inlineRadio4_' + i + '"value="option4" /><label class="form-check-label" for="inlineRadio4_' + i + '">4</label></div><div class="form-check form-check-inline"><input class="form-check-input" type="radio" name="inlineRadioOptions ' + i + ' " id="inlineRadio5_' + i + '" value="option5" /><label class="form-check-label" for="inlineRadio5_' + i + '">5</label></div><div class="form-check form-check-inline"><input class="form-check-input" type="radio" name="inlineRadioOptions ' + i + ' " id="inlineRadio6_' + i + '"value="option6" /><label class="form-check-label" for="inlineRadio6_' + i + '">6</label></div><div class="d-inline me-4" style="color:#00b300; font-weight:bold">Foarte multumit</div>'
       // document.querySelector("body").appendChild(div);
            var div_child = document.createElement('div');
            div_child.className = "text-center";

            div_child.innerHTML = ' <div class="text-center"><p><strong> ' + questions[i] + '</strong></p></div >';
            document.getElementById("questions").appendChild(div_child);
            document.getElementById("questions").appendChild(div);
        }

    </script>
</asp:Content>
