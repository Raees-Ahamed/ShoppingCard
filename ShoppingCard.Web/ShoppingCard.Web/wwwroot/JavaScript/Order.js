
var productName;
var description;
var unitPrice;
var qty;
var Items = [];


//Add Order Line Items to the table

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

//Create OrderLine

function AddOrderLine() {
    
    var orderLine = {
        ProductId: 0,
        Description: null,
        Price: 0,
        Qty: 0,
        OrderId: 0,
        IsDelete:false
    };

    orderLine.ProductId = parseInt(productName);
    orderLine.Description = description;
    orderLine.Price = parseInt(unitPrice);
    orderLine.Qty = parseInt(qty);
    orderLine.OrderId = 0;

    Items.push(orderLine);
}
//AddOrder
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

    http.open("POST", "../Order/CreateOrder", true);
    http.setRequestHeader("Content-Type", "application/json");
    http.send(JSON.stringify(orders));
    location.replace("../Order/GetAllOrders");
}
//Edit Order
function SetOrder(id) {

    var orderLineId = document.getElementById("orderLineId "+id).innerHTML;
    var productId = document.getElementById("productId "+id).value;
    var price = document.getElementById("price "+id).value;
    var quantity = document.getElementById("qty "+id).value;
    var orderId = document.getElementById("orderId "+id).innerHTML;

    var orderItems = {
        Id: parseInt(orderLineId),
        ProductId: parseInt(productId),
        Price: parseInt(price),
        Qty: parseInt(quantity),
        OrderId: parseInt(orderId),
        IsDelete:false
    };

    console.log(orderItems);

    Items.push(orderItems);
}


function RemoveOrder(id) {
    var orderLineId = document.getElementById("orderLineId " + id).innerHTML;
    var productId = document.getElementById("subId " + id).innerHTML;
    console.log(productId);
    var price = document.getElementById("price " + id).value;
    var quantity = document.getElementById("qty " + id).value;
    var orderId = document.getElementById("orderId " + id).innerHTML;

    var RemoveItems = {
        Id: parseInt(orderLineId),
        ProductId: parseInt(productId),
        Price: parseInt(price),
        Qty: parseInt(quantity),
        OrderId: parseInt(orderId),
        IsDelete:true
    };

    Items.push(RemoveItems);
}

function EditOrder() {

    var d = new Date();
    var currentDate = JSON.stringify(d);

    order = {
        Id:0,
        CustomerId: 0,
        Date: null,
        OrderItems: Items
    }

    var idvalue = document.getElementById("tempOrderId").innerHTML;
    order.Id = parseInt(idvalue);
    RemoveOrder.Id = parseInt(idvalue);
    order.Date = currentDate.replace(/^"(.*)"$/, '$1');
    RemoveOrder.Date = currentDate.replace(/^"(.*)"$/, '$1');

    var http2 = new XMLHttpRequest();
    http2.open("POST","../ChangeOrder", true);
    http2.setRequestHeader("Content-Type", "application/json");
    http2.send(JSON.stringify(order));
    alert("Updated Successfully");
    location.replace("../GetAllOrders");
}