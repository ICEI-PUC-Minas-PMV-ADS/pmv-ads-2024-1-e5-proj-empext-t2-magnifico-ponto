// Exemplo de script para manipular eventos do formulário
document.getElementById("infoContatoForm").onsubmit = function(event) {
    event.preventDefault(); // Previne o envio do formulário
    alert("Informações atualizadas com sucesso!");
    // Aqui você pode adicionar o código para processar os dados do formulário
};

function atualizarFotoPerfil(novoCaminho) {
    document.getElementById('fotoPerfil').src = novoCaminho;
}

const imagemCarregada = document.getElementById('imagem-carregada');
        const imagemBase64 = localStorage.getItem('imagem');

        if (imagemBase64) {
            imagemCarregada.src = imagemBase64;
        }