document.querySelectorAll('.infomenu, .prodmenu, .contactmenu').forEach(element => element.addEventListener('click', function(){
    const styleDisplay = window.getComputedStyle(this.nextElementSibling).display
    if(styleDisplay === 'none'){
        return this.nextElementSibling.style.display = 'block'
    }
    return this.nextElementSibling.style.display = 'none'
}))

function myFunction(x) {
    x.classList.toggle("change");
}

document.querySelector('.container').addEventListener("click", function() {
    const mobile_left_menu = document.querySelector('.mobile_left_menu')
    // const styleDisplay = window.getComputedStyle(mobile_left_menu).display
    const styleDisplay = window.getComputedStyle(mobile_left_menu).width
    // if(styleDisplay === 'block'){

    if(styleDisplay === '0px'){
        // return mobile_left_menu.style.display = 'block'
        return mobile_left_menu.style.width = '320px'

    }
    return mobile_left_menu.style.width = '0px'
}) 


document.querySelector('.account_but').addEventListener("click", function() {
    const account_drop_menu = document.querySelector('.account_drop_menu')
    const styleDisplay = window.getComputedStyle(account_drop_menu).height

    if(styleDisplay === '0px'){
        // account_drop_menu.style.overflow = 'hidden'
        return account_drop_menu.style.height = 'fit-content'

    }
    return account_drop_menu.style.height = '0px'
}) 
