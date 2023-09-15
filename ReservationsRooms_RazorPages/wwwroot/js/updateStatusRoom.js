//const btn_currentClick;
//const btn_currentClickId



/*const btn_1_ToAvailable = document.getElementById("1:available"); */

// create connection
var connectionStatusHub = new signalR.HubConnectionBuilder()
    .withUrl("/hubs/statushub")
    .Build();

btn_1_ToAvailable.addEventListener("click", function (e) {
    connectionStatusHub.send("NewStatusRoomLoaded", "1:available");
    e.preventDefault();
});
//btn_currentClickId= document.addEventListener("click", function (event) {
//    return event.target.id;
//});

//btn_currentClick = document.getElementById(btn_currentClickId);

//btn_currentClick.addEventListener("click"), function (event) {
//    connectionStatusHub.send("NewStatusRoomLoaded", btn_currentClickId)
//}


//connect to method that hub invokes, aka receive shange status from hub
connectionStatusHub.on("changeStatus", function (status, id) {
    var lblCurrent = document.getElementById(`${status}${id}`);
    if (typeof (lblCurrent) != 'undefined' && lblCurrent != null) {
        // Exists
        lblCurrent.innerText = status;
        lblCurrent.classList.remove;
        switch (status) {
            case "renovation":
                lblCurrent.add("btn btn-secondary");
                break;
            case "available":
                llblCurrent.add("btn btn-success");
                break;
            case "busy":
                llblCurrent.add("btn btn-danger");
                break;
            case "cleaning":
                llblCurrent.add("btn btn-warning");
                break;
            default:
                break;
        }
    }
    else {
        (Console.log('$Current label undefined'))
    }

})

// invoke hub method, aka send notification to hub
//function changeStatus(id, status) {
//    
    
//    /*connectionStatusHub.send("NewStatusRoomLoaded", id, status)*/
//}

//start connection
function fullfilled() {
// do something on start
console.log("Connection to Status Hub Successful")
}

function rejected() {
//rejected logs
}

connectionStatusHub.start().then(fullfilled, rejected);