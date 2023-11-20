
# Teste Licitação

## Backend
1. Esta sendo armazenado ao banco, após realizar a consulta dos dados do ativo.
2. Todo o backend foi preparado utilizando metodologias de clean code e entityFramework
3. Banco de dados utilizado foi o SQL Server
4. Foi implementado o TDD simples para alguns testes em questões de consulta e campo null ou empty
5. Todo o sistema esta em .NET 7.0
6. Sistema foi criado com modelo de injeção de dependencia(Respeitando as camadas de interface e camadas de execução)
7. Foi implementado o sistema de camadas: uma para acesso a dados, uma camada para rodagem da aplicação e outra para camada de testes XUnit

## Front-end
1. Foi utilizado javascript, jquery, html, bootstrap, ajax e dataTable
2. O Ajax foi utilizado para consultas ao back-end
3. Foram utilizadas partialView para criação de grid para trazer os dados de cada dia do mês do ativo

## Como Rodar
1. É necessário o download do SQL Server, Visual Studio e o .Net 7.0 para a utilização do sistema
2. Clonar o projeto no github
3. Rodar o sql da tabela de Licitação que está na pasta sql dentro da pasta do projeto
4. Rode o sistema
5. Na tela Inicial teremos as seguintes pesquisas por: Número Licitação, Data licitação, Descrição Licitação e Status Licitação
6. Será trago todos as licitações cadastradas
7. Temos o adicionar para criar uma nova licitação com os mesmo campos mencionados anteriormente
8. Após criar na tabela, temos a opção de editar a Licitação, que entrará na tela para editar na mão os dados
9. E também na tabela temos a opção de deletar a licitação

Links para download:

Visual Studio:
https://visualstudio.microsoft.com/pt-br/downloads/

.Net 7.0:
https://dotnet.microsoft.com/en-us/download/dotnet/7.0

Sql Server:
https://aka.ms/ssmsfullsetup
