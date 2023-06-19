document.querySelectorAll('#open_filter').forEach(element => element.addEventListener('click', function(){
    const styleDisplay = window.getComputedStyle(this.nextElementSibling).height
    if(styleDisplay === '0px'){
       
        if(this.className === 'price_filter')
        {
            document.querySelector('.price_range_input').style.display = 'block'
        }
        return this.nextElementSibling.style.height = '70px'
    }
    else{
        
        if(this === '.price_filter')
        {
            document.querySelector('.price_range_input').style.display = 'none'
        }
        return this.nextElementSibling.style.height = '0px'
    }
}))

function myFunction(x) {
    x.classList.toggle("change");
}


document.querySelectorAll('#open_filter p').forEach(element => element.addEventListener('click', function(){
    

    if(this.className === 'pointer_close')
    {
        this.className = 'pointer_open'
    }
    else{
        this.className = 'pointer_close'
    }  
}))



// document.querySelector('opne_filter').addEventListener("click", function() {
//     const mobile_left_menu = document.querySelector('.mobile_left_menu')
//     // const styleDisplay = window.getComputedStyle(mobile_left_menu).display
//     const styleDisplay = window.getComputedStyle(mobile_left_menu).width
//     console.log(styleDisplay)
//     // if(styleDisplay === 'block'){

//     if(styleDisplay === '0px'){
//         // return mobile_left_menu.style.display = 'block'
//         return mobile_left_menu.style.width = '320px'

//     }
//     return mobile_left_menu.style.width = '0px'
// }) 