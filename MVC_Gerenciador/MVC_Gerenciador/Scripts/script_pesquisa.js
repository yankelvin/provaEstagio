
function pesquisa_git() {
    let input = document.getElementsByClassName("barra-pesquisa")[0];
    let value = input.value.replace(" ", "+");

    let git_page = "https://github.com/search?q=";
    location.href = git_page + value;
}