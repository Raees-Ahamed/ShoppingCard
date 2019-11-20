
var productName;
var description;
var unitPrice;
var qty;
function AddItems() {
    var table = document.getElementById("orderTable");
     productName = document.getElementById("productId").value;
     description = document.getElementById("description").value;
     unitPrice = document.getElementById("unitPrice").value;
     qty = document.getElementById("qty").value
     subTotal = unitPrice * qty;

    var productId = document.createElement("input");
    productId.setAttribute("type", "text");
    productId.setAttribute("class", "form-control");
    productId.disabled = true;

    var productDescription = document.createElement("input");
    productDescription.setAttribute("type", "text");
    productDescription.setAttribute("class", "form-control");
    productDescription.disabled = true;

    var productUnitPrice = document.createElement("input");
    productUnitPrice.setAttribute("type", "text");
    productUnitPrice.setAttribute("class", "form-control");
    productUnitPrice.disabled = true;

    var productQty = document.createElement("input");
    productQty.setAttribute("type", "number");
    productQty.setAttribute("class", "form-control");
    productQty.setAttribute("min", "0");
    

    var btn = document.createElement("input");
    btn.setAttribute("type", "button");
    btn.setAttribute("class", "btn btn-danger");
    btn.setAttribute("value", "Delete");

    productId.value = productName;
    productDescription.value = description; 
    productUnitPrice.value = unitPrice; 
    productQty.value = qty; 

    var row = table.insertRow(1);

    var cell1 = row.insertCell(0);
    var cell2 = row.insertCell(1);
    var cell3 = row.insertCell(2);
    var cell4 = row.insertCell(3);
    var cell5 = row.insertCell(4);
    var cell6 = row.insertCell(5);

    cell1.appendChild(productId);
    cell2.appendChild(productDescription);
    cell3.appendChild(productUnitPrice);
    cell4.appendChild(productQty);
    cell5.innerHTML = subTotal;
    cell6.appendChild(btn);

    AddOrderLine();
}


var products = [];
var orderLine;
function AddOrderLine() {
    
    orderLine = {
        ProductId: 0,
        Description: null,
        UnitPrice: 0,
        Quantity: 0,
        OrderId: 0
    };

    orderLine.ProductId = parseInt(productName);
    orderLine.Description = description;
    orderLine.UnitPrice = parseInt(unitPrice);
    orderLine.Quantity = parseInt(qty);
    orderLine.OrderId = 0;

    products.push(orderLine);

    console.log(products);

    
}

function confirmOrder() {
    var http = new XMLHttpRequest();

    var Customer = document.getElementById("customerId").value;

    var d = new Date();
    var currentDate = JSON.stringify(d);
    

    var orders = {
        OrderDate: currentDate.replace(/^"(.*)"$/, '$1'),
        CustomerId: parseInt(Customer),
        OrderItems: products
    };

    console.log(JSON.stringify(orders));

    http.open("POST", "../Order/Addorder", true);
    http.setRequestHeader("Content-Type", "application/json");
    http.send(JSON.stringify(orders));
    location.replace("../Order/GetAllOrders");
}