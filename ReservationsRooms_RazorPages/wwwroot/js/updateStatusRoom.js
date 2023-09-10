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
connectionStatusHub.on("changeStatus", (status, id) => {
    var lblCurrent = document.getElementById(status + id);
    lblCurrent.innerText = status;
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