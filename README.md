# TestLemonWay

Procédure pour publier un services web et le consulter : 

1) Ouvrir le gestionnaire des services Internet 

2) Créer un pool d'application 
    Attention vérifier bien le framework 
    
3) Créer un dossier sur votre ordinateur/ ou serveur

4) Publier le services web dans le dossier ci-dessus 

5) Dans le gestionnaire IIS, aller dans le navigateur, clique droit sur Sites et ajouter un site Web

6) Attacher le pool d'application créé auparavant, nommer le site et definir le chemin d'accès physique (lieu ou vous avez publié le service), définir le port (20558)


Consulter le service via un client

1) Ajouter une référence de service 
  - Aller dans Avancé.., Ajouter une référence web tout en bas 
  - Mettre l'URL que vous avez créer dans le gestionnaire IIS exemple : (http://localhost:20558/WS_LemonWay.asmx)
  - Nommer la référence Web (WSLemonWay)
  
  !!! Attention à chaque fois que vous re-publier le service web il faut le remettre à jour dans le projet où il est référencé. 
