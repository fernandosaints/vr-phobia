# VR Phobia

Este projeto tem como objetivo criar uma experiência de realidade virtual imersiva e responsiva, adaptando dinamicamente o ambiente com base nos batimentos cardíacos do usuário. Através de um sensor de batimentos cardíacos conectado a uma placa Arduino, o ambiente virtual se ajusta conforme o aumento da frequência cardíaca, oferecendo uma experiência interativa para pessoas com fobias específicas, como acrofobia, nictofobia, talassofobia e claustrofobia.

### Guia de instruções

**Para clonar e executar o projeto:**

* Passo 1: Instale o Unity Hub (se ainda não estiver instalado) e a versão do Unity usada no projeto (verifique o arquivo README do repositório para saber a versão correta).
* Passo 2: Acesse o repositório do projeto no GitHub.
* Passo 3: Copie o link de clonagem HTTPS ou SSH do repositório.
* Passo 4: Abra o Git Bash (ou um terminal de sua preferência) e navegue até a pasta onde deseja clonar o projeto.
* Passo 5: No terminal, execute o comando git clone <URL do repositório>.
* Passo 6: Após o clone ser concluído, abra o Unity Hub e clique em “Add” para adicionar o projeto clonado.
* Passo 7: Navegue até a pasta do projeto clonado e selecione-a. O projeto será carregado no Unity.
* Passo 8: Certifique-se de que todos os pacotes necessários estão instalados (como o XR Plugin Management). O Unity pode solicitar a instalação de dependências adicionais; aceite essas solicitações.
* Passo 9: Clique em "Play" no editor do Unity para iniciar o projeto e testar as cenas de realidade virtual.

> Alternativa:

* Caso prefira, é possível baixar o projeto como um arquivo .zip diretamente do GitHub, descompactá-lo e seguir os passos a partir do Passo 6.

> Melhor opção:

* Clonar o repositório via Git garante que você tenha acesso às atualizações mais recentes e facilita o controle de versões.

**Para configurar o equipamento de realidade virtual, faça:**

* Passo 1: Conecte o dispositivo de VR (por exemplo, Oculus Rift, HTC Vive) ao seu computador.
* Passo 2: Verifique se os drivers e softwares necessários estão instalados.
* Passo 3: No Unity, verifique se o XR Plugin Management está ativado. Vá até o menu Edit > Project Settings > XR Plugin Management e ative o suporte para o seu dispositivo VR.
* Passo 4: Com o dispositivo conectado e o projeto carregado no Unity, clique em "Play" para iniciar a simulação de VR.

> Melhor opção:

* Utilizar o dispositivo VR configurado corretamente proporcionará uma experiência completa e imersiva, especialmente para os testes de biofeedback.

**Para conectar e configurar o sensor de batimentos cardíacos com a placa Arduino, faça:**

* Passo 1: Conecte o sensor de batimentos cardíacos e oxímetro (modelo MAX30102) ao Arduino (modelo Uno R3) e conecte a placa ao computador via cabo USB.
* Passo 2: No Unity, certifique-se de que o script que recebe os dados do Arduino está funcionando corretamente.
* Passo 3: Após garantir que o sensor está capturando os batimentos corretamente, inicie a simulação no Unity clicando em "Play".

> Alternativa:

* Se você estiver usando um sensor diferente, será necessário ajustar o script no Unity para que os dados do novo sensor sejam interpretados corretamente.

> Melhor opção:

* Teste o sensor e a placa Arduino em uma aplicação simples antes de rodar o projeto no Unity, para evitar problemas de conexão durante a execução do programa.
