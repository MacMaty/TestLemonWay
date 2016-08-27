# TestLemonWay

Procédure pour publier un services web et le consulter : 

1) Ouvrir le gestionnaire des services Internet 

![2016-08-27_11h59_34](https://cloud.githubusercontent.com/assets/5879425/18026774/b16dfacc-6c51-11e6-907f-1da64e265a95.png)

2) Créer un pool d'application 

    Attention vérifier bien le framework 
    
![2016-08-27_12h02_49](https://cloud.githubusercontent.com/assets/5879425/18026805/42aa6304-6c52-11e6-9d2e-611021e4e596.png)
    
3) Créer un dossier sur votre ordinateur/ ou serveur

4) Publier le services web dans le dossier ci-dessus 

![2016-08-27_12h04_42](https://cloud.githubusercontent.com/assets/5879425/18026813/5ce21910-6c52-11e6-8518-cb5182411637.png)

![2016-08-27_12h05_04](https://cloud.githubusercontent.com/assets/5879425/18026822/85cab8c8-6c52-11e6-801b-05ba5e520688.png)

![2016-08-27_12h06_08](https://cloud.githubusercontent.com/assets/5879425/18026836/f3c6671e-6c52-11e6-9951-6195c1a6cfeb.png)

5) Dans le gestionnaire IIS, aller dans le navigateur, clique droit sur Sites et ajouter un site Web

6) Attacher le pool d'application créé auparavant, nommer le site et definir le chemin d'accès physique (lieu ou vous avez publié le service), définir le port (20558)

![2016-08-27_12h07_07](https://cloud.githubusercontent.com/assets/5879425/18026841/0755aa06-6c53-11e6-9ad0-279b9fd4a8c4.png)

Consulter le service via un client

1) Ajouter une référence de service 

![2016-08-27_12h17_32](https://cloud.githubusercontent.com/assets/5879425/18026843/1f461466-6c53-11e6-87fb-0a892af5bec4.png)

  - Aller dans Avancé.., Ajouter une référence web tout en bas 
  
![2016-08-27_12h17_44](https://cloud.githubusercontent.com/assets/5879425/18026845/2a7a6c06-6c53-11e6-9635-e49fd2ab2313.png)

Mettre l'URL que vous avez créer dans le gestionnaire IIS exemple : (http://localhost:20558/WS_LemonWay.asmx)
Nommer la référence Web (WSLemonWay)

![2016-08-27_12h18_16](https://cloud.githubusercontent.com/assets/5879425/18026849/4d0d6692-6c53-11e6-927a-80aaa6691b28.png)  

  !!! Attention à chaque fois que vous re-publier le service web il faut le remettre à jour dans le projet où il est référencé. 
