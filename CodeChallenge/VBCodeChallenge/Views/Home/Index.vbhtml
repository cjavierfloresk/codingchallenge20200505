﻿@Code
    ViewData("Title") = "Home Page"
End Code

<div class="alert alert-info" style="margin-top:50px">
    Using Javascript, write a function to check whether any of 5 text input fields contain a duplicate/repeated value. If there are duplicate values, highlight the duplicate value fields and write the duplicate values to the console log.
</div>
<table class="table table-condensed" id="tbl_ex1">
    <tr>
        <td><input type="text" id="txt1" name="txt1" class="form-control" /></td>
    </tr>
    <tr>
        <td><input type="text" id="txt2" name="txt2" class="form-control" /></td>
    </tr>
    <tr>
        <td><input type="text" id="txt3" name="txt3" class="form-control" /></td>
    </tr>
    <tr>
        <td><input type="text" id="txt4" name="txt4" class="form-control" /></td>
    </tr>
    <tr>
        <td><input type="text" id="txt5" name="txt5" class="form-control" /></td>
    </tr>
    <tr>
        <td>
            <center>
                <button class="btn btn-default" type="button" onclick="checkDuplicated()">Check for duplicated</button>
            </center>
        </td>
    </tr>
</table>

<div class="alert alert-info" style="margin-top:50px">
    Using CSS, style all checkboxes responsively such that they are the default size when viewed on a laptop, 16px square on a tablet and 3em square on a cell phone.
</div>
<input type="checkbox" class="responsivechk" />
<input type="checkbox" class="responsivechk" />
<input type="checkbox" class="responsivechk" />

<div class="alert alert-info" style="margin-top:50px">
    Using VBScript, write a loop for the necessary number of times, where each loop adds a letter to a string (strDUDH_2), such that the final value of the string is the following “Todo individuo tiene derecho a la vida, a la libertad y a la seguridad de su persona.” Then, replace each instance of the letter “o” with “@("@")”.
</div>


@Code
    Dim strDUDH_2 As String = "Todo individuo tiene derecho a la vida, a la libertad y a la seguridad de su persona."
    Dim strDUDH_2_Out As String = Replace(strDUDH_2, "o", "@")
End Code
<code>
    Dim strDUDH_2 As String = "Todo individuo tiene derecho a la vida, a la libertad y a la seguridad de su persona."<br />
    Dim strDUDH_2_Out As String = Replace(strDUDH_2, "o", "@("@")")
</code>
<br />
<br />

@strDUDH_2_Out


<div class="alert alert-info" style="margin-top:50px">
    Using T-SQL, write a SELECT statement to join 2 tables and select only the top row from the second table. For example, join the table Accounts on the table PhoneNumbers (ON ACCT_ID = PH_AcctID) and only get the top matching row from the PhoneNumbers table (ORDER BY PH_CreatedOn DESC)
</div>
<textarea cols="2" rows="2" readonly="readonly" class="form-control" style="width:100%;height:550px">
    CREATE TABLE Accounts(
    Acct_Id INT NOT NULL IDENTITY (1,1) PRIMARY KEY,
    Acct_No INT NOT NULL)
    GO

        CREATE TABLE PhoneNumbers(
    PH_Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    PH_AcctId INT NOT NULL,
    PH_Number VARCHAR(255) NOT NULL,
    PH_CreatedOn DATETIME NOT NULL)
    GO

        INSERT INTO Accounts(Acct_No) VALUES (1), (2), (3), (4), (5), (6)
    GO

        INSERT INTO PhoneNumbers(PH_AcctId, PH_Number, PH_CreatedOn)
    VALUES (1, '111-11111', '2020-01-01'),(1, '222-22222', '2020-01-02'),(1, '333-33333', '2020-01-03'),
    (2, '111-11111', '2020-01-01'),(2, '222-22222', '2020-01-02'),(2, '333-33333', '2020-01-03'),
    (3, '111-11111', '2020-01-01'),(3, '222-22222', '2020-01-02'),(3, '333-33333', '2020-01-03'),
    (4, '111-11111', '2020-01-01'),(4, '222-22222', '2020-01-02'),(4, '333-33333', '2020-01-03'),
    (5, '111-11111', '2020-01-01'),(5, '222-22222', '2020-01-02'),(5, '333-33333', '2020-01-03'),
    (6, '111-11111', '2020-01-01'),(6, '222-22222', '2020-01-02'),(6, '333-33333', '2020-01-03')
    GO

    SELECT Acct_Id, ( SELECT TOP 1 pns.PH_Number FROM PhoneNumbers pns WHERE pns.PH_AcctID = ac.Acct_Id ORDER BY PH_CreatedOn DESC) PhoneNumber
    FROM Accounts ac
</textarea>

<code>
    <table class="table">
        <thead>
            <tr>
                <th>
                    Acct_Id
                </th>
                <th>
                    PhoneNumber
                </th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>1</td>
                <td>333-33333</td>
            </tr>
            <tr>
                <td>2</td>
                <td>333-33333</td>
            </tr>
            <tr>
                <td>3</td>
                <td>333-33333</td>
            </tr>
            <tr>
                <td>4</td>
                <td>333-33333</td>
            </tr>
            <tr>
                <td>5</td>
                <td>333-33333</td>
            </tr>
            <tr>
                <td>6</td>
                <td>333-33333</td>
            </tr>
        </tbody>
    </table>
</code>

<div class="alert alert-info" style="margin-top:50px">
    Using REGEX and Javascript, write an expression to check that a text input field’s value contains at least one lowercase letter, one uppercase letter, one number and one special character
</div>
<table class="table table-condensed" id="tbl_ex3">
    <tr>
        <td><input type="text" id="txt_ex3" name="txt_ex3" class="form-control" /></td>
    </tr>
    <tr>
        <td>
            <center>
                <button class="btn btn-default" type="button" onclick="checkRegex()">Check using regex</button>
            </center>
        </td>
    </tr>
</table>



<script type="text/javascript">
    function checkDuplicated() {
        var duplicatedInputs = new Array();

        $($('#tbl_ex1 input')).each(function () {
            var $input = $(this);
            var value = $input.val();
            var id = $input.attr('id');
            $('#' + id).removeClass('duplicated');

            $($('#tbl_ex1 input:not(#' + id + ")")).each(function () {
                var $currentInput = $(this);
                var currentValue = $currentInput.val();
                var currentId = $currentInput.attr('id');

                if (currentValue === value) {
                    if (findInArray(duplicatedInputs, "id", id).length === 0)
                        duplicatedInputs.push({ id: id });

                    if (findInArray(duplicatedInputs, "id", currentId).length === 0)
                        duplicatedInputs.push({ id: currentId });
                }
            });

        });


        $(duplicatedInputs).each(function () {
            var inputId = this.id;
            $('#' + inputId).addClass('duplicated');
            console.log($('#' + inputId).val());
        });
    }

    function checkRegex() {
        var regex = new RegExp("^(?=.{1,})(?=.*[a-z])(?=.*[0-9])(?=.*[A-Z])(?=.*[@("@")#$%^&+*!=]).*$");
        var value = $('#txt_ex3').val();

        if (regex.test(value)) {
            alert("Passed!");
        }
        else {
            alert("Failed!");
        }
    }

    //finds objects in json array based on property - value
    function findInArray(array, key, val) {
        var objects = [];
        for (var i in array) {
            if (!array.hasOwnProperty(i)) continue;
            if (typeof array[i] == 'object') {
                objects = objects.concat(findInArray(array[i], key, val));
            } else if (i == key && array[key] == val) {
                objects.push(array);
            }
        }
        return objects;
    }
</script>