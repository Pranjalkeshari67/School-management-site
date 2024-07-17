function OnsubmitEvent(e, t) {
    $(".error").remove();
    if (!validations()) {
        console.log("Not Submitted");
        return false;
    }
    else {
        console.log("Form Submited");
        $(t).attr("action", "/Admin/addBlog");
    }
}
//Regular Expression function Starts

//function IsEmail(email) {
//    const regex =
//        /^([a-zA-Z0-9_\.\-\+])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;
//    if (!regex.test(email)) {
//        return false;
//    }
//    else {
//        return true;
//    }
//}

//Regular Expression for function end



//Validation function Starts
function validations() {
    //debugger;
    var Heading = $("#list-title").val();
    var image = $("#image").val();
    var shortDesc = $("#shortDesc").val();
    var Description = $("#Description").val();
    var category = $("Category").val();
    var check = 0;

    if (Heading == '') {
        $('#list-title').after('<span class="error">This field is required</span>');
        check = 1;
        //debugger;
    }



    if (image == '') {
        $('#image').after('<span class="error">This field is required</span>');
        check = 1;
        //debugger;
    }
    

    if (shortDesc == "") {

        $('#shortDesc').after('<span class="error">This field is is required</span>');
        check = 1;
        //debugger;
    }
    else if (shortDesc.length>200) {
        $('#shortDesc').after('<span class="error">Short Dscription must be less than 200 words</span>');
        check = 1;
        //debugger;
    }
   

    if (Description == '') {
        $('#Description').after('<span class="error">This field is required</span>');
        check = 1;
        //debugger;
    }
   
    


    if (category == '') {
        $('#list-title').after('<span class="error">This field is required</span>');
        check = 1;
        //debugger;
    }
    
   

    //if 1 not submit the form, if 0 form will submit
    if (check == 1) {
        //debugger;
        console.log("I am Checked, False 1");
        return false;
    }
    else {
        //debugger;
        console.log("I am Checked, True 0");
        return true;
    }

}
//------------------------------------------------------------


//Teacher Validation
function OnSubmitTeacherForm(e, t)
{
    console.log("called");
    console.log("called");
    //$(".error").remove();
    if (!TeacherFormValidations()) {
        console.log("Not Submitted");
        return false;
    }
    else {
        console.log("Form Submited");
        $(t).attr("action", "/Admin/addTeacher");
       /* alert("Form Submitted");*/
    }
}

function TeacherFormValidations() {
    //debugger;
    debugger;
    var Name = $("#tName").val();
    var image = $("#timage").val();
    var subject = $("#tsub").val();
    var check = 0;
    debugger;
    console.log(Name);

    if (Name == '') {
        $('#tName').after('<span class="error">This field is required</span>');
        check = 1;
        //debugger;
    }

    if (image == '') {
        $('#timage').after('<span class="error">This field is required</span>');
        check = 1;
        //debugger;
    }

    if (subject == '' || subject == null) {
        $('#tsub').after('<span class="error">This field is required</span>');
        check = 1;
        //debugger;
    }


    //if 1 not submit the form, if 0 form will submit
    if (check == 1) {
        //debugger;
        console.log("I am Checked, False 1");
        return false;
    }
    else {
        //debugger;
        console.log("I am Checked, True 0");
        return true;
    }
}
//Teacher Validation



//function onlyAlphabets(e, t) {
//    console.log("working");
//    try {
//        if (window.event) {
//            var charCode = window.event.keyCode;
//        }
//        else if (e) {
//            var charCode = e.which;
//        }
//        else { return true; }
//        if ((charCode > 64 && charCode < 91) || (charCode > 96 && charCode < 123) || (charCode == 32))
//            return true;
//        else
//            return false;
//    }
//    catch (err) {
//        alert(err.Description);
//    }
//}