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