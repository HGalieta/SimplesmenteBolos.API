# SimplesmenteBolos.API

Projeto desenvolvido por Henrique Galieta (<https://linkedin.com/in/henriquegalieta>).

Este projeto consiste em uma API de cadastro de produtos+cliente além do envio de e-mails. Os e-mails são enviados para o cliente no momento de seu registro com a lista de produtos, confirmando seu pedido.

## Abrindo o projeto

Para rodar o projeto abra a solução `SimplesmenteBolos.API.sln` no Visual Studio Comunity 2022.

## Base de Dados

Este projeto foi desenvolvido utilizando o SQL Server, portanto você deve tê-lo instalado em seu computador, ou alterar as configurações corretamente nas linha 19 a 22 do arquivo `Program.cs`.

A base de dados `pedidosdb` pode ser gerada rodando o comando `dotnet ef database update` no console do Gerenciador de Pacotes.

## Subindo o servidor

Com o projeto aberto no Visual Studio 2022, basta pressionar o botão `F5` para iniciar o servidor que rodará por padrão com o Swagger, onde pode ser visualizados todos os endpoints da API.

Com a API online no endereço ´https://localhost:7268´, o projeto SimplesmenteBolos.UI (<https://github.com/HGalieta/SimplesmenteBolos.UI>) pode ser devidamente utilizado.
