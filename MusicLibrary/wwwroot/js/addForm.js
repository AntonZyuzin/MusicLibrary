const indexBody = document.getElementById('index_body')

const openPopUp = document.getElementById('open_pop_up');
const closePopUp = document.getElementById('close_pop_up');
const popUp = document.getElementById('pop_up');

openPopUp.addEventListener('click', function (e) {
    e.preventDefault();
    popUp.classList.add('active');
    indexBody.classList.add('active');
    return false;
})

closePopUp.addEventListener('click', function (e) {
    e.preventDefault();
    popUp.classList.remove('active');
    indexBody.classList.remove('active');
    return false;
})
