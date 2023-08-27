﻿
// create connection
var connectionStatusHub = new signalR.HubConnectionBuilder()
    .withUrl("/hubs/statushub")
    .Build();

//connect to method that hub invokes, aka receive shange status from hub
connectionStatusHub.on("changeStatus", (id, currentStatus, newStatus) =>{
    /*const currentIdStatus = id + status;*/
    const currentIdStatus = document.getElementById(id+currentStatus);
    currentIdStatus.innerText = newStatus.toString();
})

// invoke hub method, aka send notification to hub
function NewStatusRoomLoadedOnClient() {
    //var status = document.getElementById(currentStatus);
    //var id = document.getElementById(currentId);
    connectionStatusHub.send("NewStatusRoomLoaded", id, status)
}

//start connection
function fullfilled() {
// do something on start
console.log("Connection to Status Hub Successful")
}

function rejected() {
//rejected logs
}

connectionStatusHub.start().then(fullfilled, rejected);