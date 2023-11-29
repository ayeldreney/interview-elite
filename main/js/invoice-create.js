
      
        var parentAll = document.querySelectorAll('.invoice-details-table tbody tr').forEach(el => {
        let textFields = el.querySelectorAll(".muted-text input[type=text]");
    console.log(textFields);
    let qty = textFields[0];
    let price = textFields[1];
    if (qty == undefined || price == undefined) return;
    let totalFieldPriceSpan = el.querySelector('.text-primary span');

            qty.addEventListener('input', e => {
                if (isNaN(parseInt(qty.value)) || isNaN(parseInt(price.value))) {
        totalFieldPriceSpan.innerHTML = 0
    };
               

                if (price.value > 0 && qty.value > 0) {
        totalFieldPriceSpan.innerHTML = price.value * qty.value;
                }
    updateNet()
            });

            price.addEventListener('input', e => {
                if (isNaN(parseInt(qty.value))) return;
    if (isNaN(parseInt(price.value))) return;

                if (price.value > 0 && qty.value > 0) {
        totalFieldPriceSpan.innerHTML = price.value * qty.value;
                }
    updateNet()
            });
        });





    function updateNet() {
            var total = 0;
            var parentAll = document.querySelectorAll('.invoice-details-table tbody tr .text-primary span:not(#totalPrice) ').forEach(el => {
        console.log(el);
    total += parseInt(el.innerHTML);
            })

    document.querySelector("#totalPrice").innerHTML = total;
         

        }

    function deleteCheckedRows() {

        document.querySelectorAll(".invoice-details-table tbody tr").forEach(e => {
            if (e.querySelector("input[type=checkbox]").checked) {
                e.remove()
                updateNet()
            }
        })



    }



