---------------
English comments
---------------

Demonstration of the framework for SRS designers.

The Demo.cs file contains sample code that demonstrates the steps to follow.

 -  DemoAjouterCertificat( ); Creating a certificate for the SRS and how to get it signed by the WEB-SRM
    -   Keypair creation (public and private)
    -   Certificate creation
    -   Transmission of the Certificate Signing Request (CSR) to the WEB-SRM to get it signed by the WEB-SRM.
    -   Reception of the two certificates : SRS and WEB-SRM
        -   Merge the SRS's private and public keys in the SRS certificate
        -   Save the SRS and WEB-SRM certificates in the Windows certificate store.

 -  DemoAjouterUtilisateur( ); Demonstration of a "USER" request
        -   Add a user on the WEB-SRM

 -  DemoTransaction( ); Demonstration of a "Transaction" request
    -   Digital signature calculation
    -   QR Code creation
        -   Encryption of the url to be encoded in the QR code with the public key contained in the WEB-SRM certificate

 -  DemoSupprimerUtilisateur( ); Demonstration of a "USER" request
        -   Delete a user on the WEB-SRM

 -  DemoSupprimerCertificat( ); Demonstration of a "Certificate" request 
        -   Delete a certificate on the SRS and on the WEB-SRM

Packages
--------

The following packages are used and can be installed with the NuGet console in Visual Studio.

 -  Newtonsoft.Json (json documents)
 -  ZXing.Net (QR Code)
 -  RestSharp version 106.15.0 (REST Communication with the WEB-SRM)
    WARNING! The framework is NOT compatible with RestSharp 107.x and later. You must use version 106.15.0

-----------------
Version Française
-----------------
Démonstration du framework pour les concepteurs de SEV dans le cadre des projets sur la facturation obligatoire.

Le fichier Demo.cs contient des exemples de code qui démontrent les étapes à suivre.

 -  DemoAjouterCertificat( ); Création d'un certificat pour le SEV et comment le faire signer par le MEV-WEB
    -   Création de la paire de clés (publique et privée)
    -   Création du certificat et demande de signature au MEV-WEB (CSR)
    -   Transmission du CSR au MEV-WEB pour signature du certificat du SEV
    -   Réception des certificats du SEV et du MEV-WEB
        -   Fusion des clés privée et publique dans le certificat du SEV
        -   Sauvegarde des certificats du SEV et du MEV-WEB dans le magasin de certificats Windows

 -  DemoAjouterUtilisateur( ); Démonstration d'une requête Utilisateur - Ajouter un utilisateur sur le MEV-WEB et valider ses numéros de taxes

 -  DemoTransaction( ); Démonstration d'une requête Transaction
    -   Calcul des signatures numériques
    -   Création du code QR
        -   Chiffrement de l'url à encoder dans le code QR avec la clé publique contenue dans le certificat du MEV-WEB

 -  DemoSupprimerUtilisateur( ); Démonstration d'une requête Utilisateur - supprimer un utilisateur sur le MEV-WEB

 -  DemoSupprimerCertificat( ); Démonstration d'une requête Certificat pour supprimer un certificat sur le SEV et sur le MEV-WEB

Packages
--------

Les packages suivants sont utilisés et peuvent être installés via la console NuGet de Visual Studio.

 -  Newtonsoft.Json (Documents json)
 -  ZXing.Net (Code QR)
 -  RestSharp version 106.15.0 (Communication REST avec le MEV-WEB)
    ATTENTION! Le framework n'est PAS compatible avec les version RestSharp 107.x et suivantes. Vous devez utiliser la version 106.15.0
