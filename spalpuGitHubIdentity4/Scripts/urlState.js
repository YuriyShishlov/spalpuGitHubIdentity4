function OnSuccessJs() {
    var url = $(this).attr("myUrl");
    var title = $(this).attr("myTitle");
    var currentState = window.history.state;
    window.history.pushState(currentState, title, url);
    return false;
}