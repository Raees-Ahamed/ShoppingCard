﻿//Load Product to the Select List in User Interface :- Add Order
function LoadProduct(id) {
    var http = new XMLHttpRequest();
    http.open("GET", "../product/GetProduct/" + id, true); 
    http.send();

    http.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            var obj = JSON.parse(this.responseText);

            if (obj != null) {
                document.getElementById("description").value = obj.description;
                document.getElementById("unitPrice").value = obj.unitPrice;                
            }
            else {
                document.getElementById("description").value = "Not Found";
                document.getElementById("unitPrice").value = "Not Found";
            }
        }
    }
}

function LoadProductEdit(id, orderid) {
    var http = new XMLHttpRequest();
    http.open("GET", "../../product/GetProduct/" + id, true);
    http.send();

    http.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            var obj = JSON.parse(this.responseText);

            if (obj != null) {
                if (orderid) {
                    document.getElementById("price" + orderid).value = obj.unitPrice;
                    document.getElementById("subId" + orderid).innerHTML = obj.Id;
                } else {
                    document.getElementById("price").value = obj.unitPrice;   
                }            
            }
            else {   
                if (orderid) {
                    document.getElementById("price" + orderid).value = obj.unitPrice;
                } else {
                    document.getElementById("price").value = "Not Found";
                }                      
            }
        }
    }

}