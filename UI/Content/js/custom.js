//Blog
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

function OnUpdateBlogEvent(e, t) {
    $(".error").remove();
    if (!Updateblogvalidations()) {
        console.log("Not Submitted");
        return false;
    }
    else {
        console.log("Form Submited");
        $(t).attr("action", "/Admin/UpdateBlog");
    }
}

function Updateblogvalidations() {
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
    else if (shortDesc.length > 200) {
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

//Teacher Validation
function OnSubmitTeacherForm(e, t)
{
    console.log("called");
    console.log("called");
    $(".error").remove();
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
    //debugger;
    var Name = $("#tName").val();
    var image = $("#timage").val();
    var subject = $("#tsub").val();
    var check = 0;
    //debugger;
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

function OnUpdateTeacherForm(e, t) {
    console.log("called");
    console.log("called");
    $(".error").remove();
    if (!TeacherUpdateFormValidations()) {
        console.log("Not Submitted");
        return false;
    }
    else {
        console.log("Form Submited");
        $(t).attr("action", "/Admin/UpdateTeacher");
        /* alert("Form Submitted");*/
    }
}

function TeacherUpdateFormValidations() {
    //debugger;
    //debugger;
    var Name = $("#tName").val();
    var image = $("#timage").val();
    var subject = $("#tsub").val();
    var check = 0;
    //debugger;
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



//event validation
function OnSubmitEventForm(e, t) {
    console.log("called");
    console.log("called");
    $(".error").remove();
    if (!eventFormValidations())
    {
        console.log("Not Submitted");
        return false;
    }
    else
    {
        console.log("Form Submited");
        $(t).attr("action", "/Admin/addEvents");
        /* alert("Form Submitted");*/
    }
}

function eventFormValidations() {
    //debugger;
    //debugger;
    var Name = $("#ename").val();
    var image = $("#ephoto").val();
    var date = $("#edate").val();
    var check = 0;
    //debugger;
    console.log(Name);

    if (Name == '') {
        $('#ename').after('<span class="error">This field is required</span>');
        check = 1;
        //debugger;
    }

    if (image == '') {
        $('#ephoto').after('<span class="error">This field is required</span>');
        check = 1;
        //debugger;
    }

    if (date == '' || date == null) {
        $('#edate').after('<span class="error">This field is required</span>');
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


function onClickDelete(e, t) {
    var x = confirm("Are you sure ?");
    if (x) {
        //debugger;
        var ob = { blogId: $(t).data("emid") };
        console.log(ob);
        //debugger;
        $.ajax({
            url: "/Admin/DeleteBlog",
            method: "post",
            data: ob,
            dataType: "json",
            contentType: "application/json",
            success: function (data) {
                if (data == "ok") {
                    swal("Deleted Successfully !");
                    setTimeout(function () {
                        location.reload(true);
                    }, 1500);
                } else {
                    swal("Sorry ! Unable to delete.")
                }
            },
            error: function (error) {
                swal("Some Error Occurred");
            }
        })
        return true;
    }
    else {
        swal("Make sure to be deleted !");
        return false;
    }

}



//Photo
function OnSubmitPhotoForm(e, t) {
    //debugger;
    console.log("called");
    console.log("called");
    $(".error").remove();
    if (!PhotoFormValidations()) {
        console.log("Not Submitted");
        return false;
    }
    else {
        console.log("Form Submited");
        $(t).attr("action", "/Admin/uploadPhotos");
        /* alert("Form Submitted");*/
    }
}

function PhotoFormValidations() {
    //debugger;
    //debugger;
  
    var images = $("#eMulPhoto").val();
    var category = $("#ecat").val();
    var check = 0;
    debugger;
   

    if (category == '') {
        $('#ecat').after('<span class="error">This field is required</span>');
        check = 1;
        //debugger;
    }

    if (images == '') {
        $('#eMulPhoto').after('<span class="error">This field is required</span>');
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
//photo End

//Contact Start
function OnSubmitContactForm(e, t) {
    //debugger;
    console.log("called");
    console.log("called");
    $(".error").remove();
    if (!ContactFormValidations()) {
        console.log("Not Submitted");
        return false;
    }
    else {
        //debugger;
        console.log("Form Submited");
        $(t).attr("action", "/Home/Contact");
        
    }
}

function ContactFormValidations() {
    //debugger;
    //debugger;

    var Name = $("#cname").val();
    var Email = $("#cemail").val();
    var Phone = $("#cphone").val();
    var Message = $("#cmessage").val();

    var check = 0;
    //debugger;


    if (Name == '') {
        $('#cname').after('<span class="error">This field is required</span>');
        check = 1;
        //debugger;
    }

    if (Email == '') {
        $('#cemail').after('<span class="error">This field is required</span>');
        check = 1;
        //debugger;
    } else if (!IsEmail(Email)) {
        $('#cemail').after('<span class="error">Please Enter a valid email</span>');
        check = 1;
    }

    if (Phone == '') {
        $('#cphone').after('<span class="error">This field is required</span>');
        check = 1;
        //debugger;
    }

    if (Message == '') {
        $('#cmessage').after('<span class="error">This field is required</span>');
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
//Contact End



function onClickDelete(e, t) {
    var x = confirm("Are you sure ?");
    if (x) {
        //debugger;
        var ob = { blogId: $(t).data("emid") };
        console.log(ob);
        //debugger;
        $.ajax({
            type: 'GET',
            url: '/Admin/DeleteBlog',
            data:ob,
            success: function (data) {
                if (data == "ok") {
                    swal("Deleted Successfully !");
                    setTimeout(function () {
                        location.reload(true);
                    }, 1500);
                } else {
                    swal("Sorry ! Unable to delete.")
                }
            },
            error: function (error) {
                swal("Some Errorrrrrr Occurred");
            }
        })
        return true;
    }
    else {
        swal("Make sure to be deleted !");
        return false;
    }

}


function onClickDeleteEvent(e, t)
{
    var x = confirm("Are You Sure!!");
    if (x)
    {
        var ob = { blogId: $(t).data("emid") }
        console.log(ob);
        debugger;
        $.ajax({
            type: 'GET',
            url: '/Admin/DeleteEvents',
            data: ob,
            success: function (data) {
                if (data == "ok") {
                    swal("Deleted Successfully !");
                    setTimeout(function () {
                        location.reload(true);
                    }, 1500);
                } else {
                    swal("Sorry ! Unable to delete.")
                }
            },
            error: function (error) {
                swal("Some Errorrrrrr Occurred");
            }

        });
        return true;
    }
    else
    {
        swal("Make sure to be deleted !");
        return false;
    }
}


function onClickDeletePhoto(e, t) {
    var x = confirm("Are you sure ?");
    if (x) {
        //debugger;
        var ob = { pid: $(t).data("emid") };
        console.log(ob);
        //debugger;
        $.ajax({
            type: 'GET',
            url: '/Admin/DeletePhotos',
            data: ob,
            success: function (data) {
                if (data == "ok") {
                    swal("Deleted Successfully !");
                    setTimeout(function () {
                        location.reload(true);
                    }, 1500);
                } else {
                    swal("Sorry ! Unable to delete.")
                }
            },
            error: function (error) {
                swal("Some Errorrrrrr Occurred");
            }
        })
        return true;
    }
    else {
        swal("Make sure to be deleted !");
        return false;
    }
}



function onClickContactDelete(e, t) {
    var x = confirm("Are you sure ?");
    if (x) {
        //debugger;
        var ob = { ctid: $(t).data("emid") };
        console.log(ob);
        //debugger;
        $.ajax({
            type: 'GET',
            url: '/Admin/DeleteContact',
            data: ob,
            success: function (data) {
                if (data == "ok") {
                    swal("Deleted Successfully !");
                    setTimeout(function () {
                        location.reload(true);
                    }, 1500);
                } else {
                    swal("Sorry ! Unable to delete.")
                }
            },
            error: function (error) {
                swal("Some Errorrrrrr Occurred");
            }
        })
        return true;
    }
    else {
        swal("Make sure to be deleted !");
        return false;
    }

}

function onClickNewsletterDelete(e,t) {
    var x = confirm("Are you sure ?");
    if (x) {
        //debugger;
        var ob = { nid: $(t).data("emid") };
        console.log(ob);
        debugger;
        $.ajax({
            type: 'GET',
            url: '/Admin/DeleteNewsletter',
            data: ob,
            success: function (data) {
                if (data == "ok") {
                    swal("Deleted Successfully !");
                    setTimeout(function () {
                        location.reload(true);
                    }, 1500);
                } else {
                    swal("Sorry ! Unable to delete.")
                }
            },
            error: function (error) {
                swal("Some Errorrrrrr Occurred");
            }
        })
        return true;
    }
    else {
        swal("Make sure to be deleted !");
        return false;
    }

}

//Newsletter
function OnSubmitNewsletterForm(e, t)
{
    console.log("called");
    console.log("called");
    $(".error").remove();
    if (!NewsletterValidations()) {
        //debugger;
        console.log("Not Submitted");
        return false;
    }
    else {
       // debugger;
        var obj = {
            newsEmail: $('#newsEmail').val()
        }
        $.ajax({
            type: 'post',
            url: 'Home/SubmitNewsLetter',
            data: obj,
            success: function (data) {
                if (data == "ok") {
                    swal("Submitted Successfully !");
                    setTimeout(function () {
                        location.reload(true);
                    }, 1500);
                } else {
                    swal("Sorry ! Unable to delete.")
                }
            },
            error: function (error) {
                swal("Some Errorrrrrr Occurred");
            }
        })
        debugger;
        return true;
         
    }
   
        /* alert("Form Submitted");*/
    
}

function NewsletterValidations() {
    //debugger;
    //debugger;
    var Email = $("#newsEmail").val();
    
    var check = 0;
    //debugger;
    console.log(Email);

    if (Email == '') {
        $('#newsEmail').after('<span class="error">This field is required</span>');
        check = 1;
        //debugger;
    } else if (!IsEmail) {
        $('#newsEmail').after('<span class="error">This field is required</span>');
        check = 1;
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




//NAVBAR ACTIVE
jQuery(function ($) {
    var path = window.location.href; // because the 'href' property of the DOM element is the absolute path
    $('#menu li a').each(function () {
        if (this.href === path) {
            
            $(this).addClass('active');

        }
    });
});


jQuery(function ($) {
    var path = window.location.href; // because the 'href' property of the DOM element is the absolute path
    $('#index-menu li a').each(function () {
        if (this.href === path) {

            $(this).addClass('menu-active');

        }
    });
});


















//Regular Expression function Starts

function IsEmail(email) {
    const regex =
        /^([a-zA-Z0-9_\.\-\+])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;
    if (!regex.test(email)) {
        return false;
    }
    else {
        return true;
    }
}

//Regular Expression for function end








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

