const openGenrePop = document.getElementById('open_genre')
const closeGenrePage = document.getElementById('close_genre');
const genrePage = document.getElementById('genre_page')

openGenrePop.addEventListener('click', function (x) {
    x.preventDefault();
    genrePage.classList.add('active');
})

closeGenrePage.addEventListener('click', function (x) {
    x.preventDefault();
    genrePage.classList.remove('active');
})