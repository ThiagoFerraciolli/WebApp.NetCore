# WebApp.NetCore
WebApp .Net Core com teste unitario

# Descrição
Este projeto é um .Net Core implementando Web API com um método de escrever um número inteiro por extenso limitado de [-999999] a [999999].

Com teste unitário em Xunit tanto no serviço como no Controller implementando HttpRequestMessage.


# Dependências para executar o código

ASP.NET CORE 2.2 SDK disponível no link abaixo:
https://dotnet.microsoft.com/download/dotnet-core/2.2

# Para Executar
Para executar o programa após clonar o projeto basta abrir o promp de comandos e navegar até WebApp.NetCore\WebApp.NetCore.Application, depois executar os comandos abaixo na ordem correspondente.

Este comando irá baixar as dependências
- dotnet restor

Este comando irá executar o server API
- dotnet run

Após este comando é só acessar o seguinte endereço no browser
http://localhost:5000/1--> o número 1 pode ser trocado por qualquer número que deseja velo por extenso.


# Para ver os testes
Para executar os testes unitários é só navegar até o endereço WebApp.NetCore\WebApp.NetCore.Test

Este comando irá executar os testes
- dotnet test

