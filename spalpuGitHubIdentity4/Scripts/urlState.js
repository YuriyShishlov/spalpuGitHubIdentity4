function OnSuccessJs() {
    var myUrl = $(this).attr("myUrl");
    var myTitle = $(this).attr("myTitle");
    var currentState = window.history.state;
    document.title = myTitle;
    window.history.pushState(currentState, myTitle, myUrl);
    return false;
}