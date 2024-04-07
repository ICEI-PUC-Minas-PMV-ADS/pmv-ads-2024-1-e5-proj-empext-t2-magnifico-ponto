document.getElementById('registerForm').addEventListener('submit', function(event) {
    event.preventDefault();
    
    var username = document.getElementById('username').value;
    var password = document.getElementById('password').value;
    
    // Aqui você pode adicionar lógica para enviar os dados de registro para o servidor
    // Por exemplo, pode fazer uma requisição AJAX para enviar os dados
    
    // Exemplo de redirecionamento para a página de login após o registro bem-sucedido
    window.location.href = 'login.html';
});
