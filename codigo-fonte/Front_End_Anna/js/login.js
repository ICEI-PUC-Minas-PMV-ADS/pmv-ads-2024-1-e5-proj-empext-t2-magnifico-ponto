document.getElementById('loginForm').addEventListener('submit', function(event) {
    event.preventDefault();
    
    var username = document.getElementById('username').value;
    var password = document.getElementById('password').value;
    
    // Aqui você pode adicionar lógica para validar o login e redirecionar conforme necessário
    // Por exemplo, pode fazer uma requisição AJAX para um servidor para verificar as credenciais
    
    // Exemplo de redirecionamento para a página de produtos após o login bem-sucedido
    window.location.href = 'produtos.html';
});
