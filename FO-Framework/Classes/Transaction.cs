﻿/*
Copyright 2022 Revenu Québec

Permission is hereby granted, free of charge, to any person obtaining a copy of this
software and associated documentation files (the "Software"), to deal in the Software
without restriction, including without limitation the rights to use, copy, modify,
merge, publish, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A
PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace FO_Framework
{
    /// <summary>
    /// Contenu d'une transaction et préparation du document json à transmettre au MEV-WEB
    /// Content of a transaction and preparation of the json document to be sent to WEB-SRM
    /// </summary>
    public class Transaction
    {
        #region Données de transaction

        /// <summary>
        /// Secteur d'activité propre à la transaction
        /// Field identifying the business's sector of activity.
        /// </summary>
        public TransactionSectActi sectActi;

        /// <summary>
        /// Le champ indiquant l’adresse de l’entreprise indiqué sur le document.
        /// Field giving the address of the business named on the document.
        /// </summary>
        public TransactionDocAdr docAdr;

        /// <summary>
        /// Les renseignements relatifs au client qui acquiert la fourniture payé ou payable.
        /// Information regarding the custumer that acquires a paid or payable supply.
        /// </summary>
        public TransactionClint clint;

        /// <summary>
        /// Liste des items de la transaction
        /// List of transaction items
        /// </summary>
        public List<TransactionItem> lstItems;

        /// <summary>
        /// Liste des transactions référencées par celle-ci
        /// List of transactions referenced by this one
        /// </summary>
        public List<TransactionReference> lsttransactionReferences;

        /// <summary>
        /// Le champ identifiant les signatures numériques générées par votre SEV pour la transaction
        /// Field identifying the digital signatures generated by your SRS for the transaction
        /// </summary>
        public TransactionSigna signa;

        /// <summary>
        /// Le montant ajusté sur le montant après taxes 
        /// Adjustment amount applied on the total( e.g. rounding, coupon, gift card, discount).
        /// </summary>
        public String Ajus { get; set; }

        /// <summary>
        /// Le montant après taxes pour la fourniture qui est constitué à la fois de la somme des champs avantTax, TPS et TVQ.
        /// Amount for the supply after taxes is the sum of the avantTax, TPS and TVQ fields
        /// </summary>
        public String ApresTax { get; set; }

        /// <summary>
        /// Le montant avant taxes est constitué de la somme du champ prix de chaque fourniture
        /// Amount before taxes is comprised of the sum of the prix field of each item and each detail.
        /// </summary>
        public String AvantTax { get; set; }

        /// <summary>
        /// L’indicateur qu’il s’agit de commerce électronique
        /// E-commerce indicator
        /// </summary>
        public string CommerceElectronique { get; set; }

        /// <summary>
        /// Le code émis par Revenu Québec qui certifie que le SEV est certifié et qu’il peut communiquer avec le MEV-WEB
        /// Code issued by us proving that the SRS is certified and can communicate with the WEB-SRM.
        /// </summary>
        public String CodCertif { get; set; }

        /// <summary>
        /// Le moment de la transaction (date, heure, minute et seconde)
        /// Time of the transaction to which the bill refers
        /// </summary>
        public String DatTrans { get; set; }

        /// <summary>
        /// L’empreinte numérique du certificat (en anglais, Thumbprint) contenant la clé publique
        /// reliée à la clé privée utilisé pour produire la signature de la transaction actuelle (actu).
        /// 
        /// Thumbprint of the certificate containing the public key linked to the private key
        /// used to produce the current transaction signature( actu)
        /// </summary>
        public String EmprCertifSEV { get; set; }

        /// <summary>
        /// Le format d’impression du document. (Papier, électronique, ...)
        /// Document print option (Paper, Electronic, ...)
        /// </summary>
        public String FormImpr { get; set; }

        /// <summary>
        /// L’identifiant unique émis par Revenu Québec pour le partenaire, c’est-à-dire vous en tant que concepteur de SEV.
        /// Unique identifier issued by us for the partner ( you as an SRS developer).
        /// </summary>
        public String IdPartn { get; set; }

        /// <summary>
        /// L’identifiant unique émis par Revenu Québec pour le nom du SEV.
        /// Unique identifier issued by us for the name of the SRS
        /// </summary>
        public String IdSev { get; set; }

        /// <summary>
        /// L’identifiant unique émis par Revenu Québec pour la version du SEV.
        /// Unique identifier issued by us for the version of the SRS.
        /// </summary>
        public String IdVersi { get; set; }

        /// <summary>
        /// Le mode d’impression du document. (Facturation, Reproduction, Duplicata, ...)
        /// Print mode for the document. (Bill, Reproduction, Duplicata, ...)
        /// </summary>
        public String ModImpr { get; set; }

        /// <summary>
        /// Le mode de paiement utilisé pour payer la facture.
        /// Method of payment used for the bill.
        /// </summary>
        public String ModPai { get; set; }

        /// <summary>
        /// Le mode de transaction utilisé. (Opération ou Formation)
        /// Transaction mode (Operation or Training)
        /// </summary>
        public String ModTrans { get; set; }

        /// <summary>
        /// Le montant dû après avoir ajusté le montant après taxes. 
        /// The amount due after adjusting the after tax amount.
        /// </summary>
        public String MTDU { get; set; }

        /// <summary>
        /// Le numéro de dossier relatif à la facturation obligatoire
        /// The mandatory billing file number.
        /// </summary>
        public String NoDossFO { get; set; }

        /// <summary>
        /// Le nom du mandataire qui exploite l’entreprise.
        /// Usual name of the mandatary who operates the business.
        /// </summary>
        public String NomMandt { get; set; }

        /// <summary>
        /// Le nom de l’utilisateur qui a produit la facture au client.
        /// Name of the user who produced the customer’s bill.
        /// </summary>
        public String NomUtil { get; set; }

        /// <summary>
        /// Le numéro qui identifie la transaction.
        /// Number identifying the transaction to which the document refers.
        /// </summary>
        public String NoTrans { get; set; }

        /// <summary>
        /// Le numéro d’inscription au fichier de la TPS attribué au mandataire.
        /// Mandatary’s GST registration number
        /// </summary>
        public String NoTPS { get; set; }

        /// <summary>
        /// Le numéro d’inscription au fichier de la TVQ attribué au mandataire.
        /// Mandatary’s QST registration number
        /// </summary>
        public String NoTVQ { get; set; }

        /// <summary>
        /// Le montant du pourboire reçu.
        /// The amount of the tip.
        /// </summary>
        public String Pourb { get; set; }

        /// <summary>
        /// Le type de relation d’affaires.
        /// The type of business relationship.
        /// </summary>
        public String RelaCommer { get; set; }

        /// <summary>
        /// Le solde du montant à payer, c’est-à-dire la valeur du champ apresTax ou mtdumoins la somme des champs versActu et versAnt
        /// The balance of the amount payable (the value of the apresTax field minus the sum of the amounts in the versActu and versAnt fields)
        /// </summary>
        public string Solde { get; set; }

        /// <summary>
        /// Le montant de la TPS payée ou payable pour la fourniture.
        /// GST paid or payable on the supply.
        /// </summary>
        public String TPS { get; set; }

        /// <summary>
        /// Le montant de la TVQ payée ou payable pour la fourniture.
        /// QST paid or payable on the supply.
        /// </summary>
        public String TVQ { get; set; }

        /// <summary>
        /// Le type de transaction. Valeurs possibles : ADDI (Addition), ESTM (Estimation), RFER (Reçu de fermeture), SOUM (Soumission), TIER (Tiers inhabituel), SOB (Sans objet)
        /// Transaction type. Possible values are: ADDI (temporary bill), ESTM (estimate), RFER (closing receipt), SOUM (quote), TIER (occasional third party), SOB (n/a)
        /// </summary>
        public String TypTrans { get; set; }

        /// <summary>
        /// Le temps universel coordonnés utilisé par le SEV.
        /// Coordinated Universal Time used by the SRS when recording the date transaction( datTrans)
        /// </summary>
        public String Utc { get; set; }

        /// <summary>
        /// Le montant du versement actuel.
        /// Amount of the current payment.
        /// </summary>
        public string VersActu { get; set; }

        /// <summary>
        /// Le montant des versements antérieurs (excluant le versement actuel).
        /// The amount of previous payments (excluding the current payment).
        /// </summary>
        public string VersAnt { get; set; }

        /// <summary>
        /// La version du SEV utilisée correspondant à la mise à jour de la version parent (versiParn).
        /// SRS/POS version assigned by the developer and corresponding to the update of the parent version (versiParn)
        /// </summary>
        public String Versi { get; set; }

        /// <summary>
        /// La version parent du SEV utilisée.
        /// Parent version of the SRS. This number is assigned by the developer.
        /// </summary>
        public String VersiParn { get; set; }

        #endregion Données de transaction

        #region Constructeurs

        /// <summary>
        /// Constructeurs
        /// </summary>
        public Transaction( )
        {
            sectActi = new TransactionSectActi( );
            docAdr = new TransactionDocAdr( );
            clint = new TransactionClint( );
            signa = new TransactionSigna( );
            lsttransactionReferences = new List<TransactionReference>( );
        }

        #endregion Constructeurs

        #region Fonctions publiques

        /// <summary>
        /// Retourne le contenu de la transaction dans un document json
        /// Returns the content of the transaction in a json document
        /// </summary>
        /// <returns>json document</returns>
        public String GetJson( )
        {
            StringBuilder s = new StringBuilder( );

            s.Append( "\"sectActi\": {" );

            if( !String.IsNullOrEmpty( sectActi.Abrvt ) )
                s.AppendFormat( "\"abrvt\": \"{0}\",", sectActi.Abrvt );

            if( !String.IsNullOrEmpty( sectActi.TypServ ) )
                s.AppendFormat( "\"typServ\": \"{0}\",", sectActi.TypServ );

            if( !String.IsNullOrEmpty( sectActi.NoTabl ) )
                s.AppendFormat( "\"noTabl\": \"{0}\",", sectActi.NoTabl );

            if( !String.IsNullOrEmpty( sectActi.NbClint ) )
                s.AppendFormat( "\"nbClint\": \"{0}\"", sectActi.NbClint );

            s.Append( "}," );

            if( !String.IsNullOrEmpty( NoTrans ) )
                s.AppendFormat( "\"noTrans\": \"{0}\",", NoTrans );

            if( !String.IsNullOrEmpty( NomMandt ) )
                s.AppendFormat( "\"nomMandt\": \"{0}\",", NomMandt );

            if( !String.IsNullOrEmpty( NomUtil ) )
                s.AppendFormat( "\"nomUtil\": \"{0}\",", NomUtil );

            if( !string.IsNullOrEmpty( docAdr.DocNoCiviq ) || !string.IsNullOrEmpty( docAdr.DocCodePostal ) )
            {
                s.Append( "\"docAdr\": {" );
                if( !String.IsNullOrEmpty( docAdr.DocNoCiviq ) )
                    s.AppendFormat( "\"docNoCiviq\": \"{0}\",", docAdr.DocNoCiviq );

                if( !String.IsNullOrEmpty( docAdr.DocCodePostal ) )
                    s.AppendFormat( "\"docCp\": \"{0}\"", docAdr.DocCodePostal );

                s.Append( "}," );
            }
            if( !string.IsNullOrEmpty( RelaCommer ) )
                s.AppendFormat( "\"relaCommer\": \"{0}\",", RelaCommer );

            if( !string.IsNullOrEmpty( clint.NomClint ) || !string.IsNullOrEmpty( clint.NoTvqClint ) || !string.IsNullOrEmpty( clint.Tel1 ) || !string.IsNullOrEmpty( clint.Tel2 ) || !string.IsNullOrEmpty( clint.Courl ) )
            {
                s.Append( "\"clint\": {" );
                if( !String.IsNullOrEmpty( clint.NomClint ) )
                    s.AppendFormat( "\"nomClint\": \"{0}\",", clint.NomClint );

                if( !String.IsNullOrEmpty( clint.NoTvqClint ) )
                    s.AppendFormat( "\"noTvqClint\": \"{0}\",", clint.NoTvqClint );

                if( !String.IsNullOrEmpty( clint.Tel1 ) )
                    s.AppendFormat( "\"tel1\": \"{0}\",", clint.Tel1 );

                if( !String.IsNullOrEmpty( clint.Tel2 ) )
                    s.AppendFormat( "\"tel2\": \"{0}\",", clint.Tel2 );

                if( !String.IsNullOrEmpty( clint.Courl ) )
                    s.AppendFormat( "\"courl\": \"{0}\"", clint.Courl );

                if( clint.lstAdrClients.Count > 0 )
                {
                    s.Append( ",\"adr\": [" );
                    for( int i = 0; i < clint.lstAdrClients.Count; i++ )
                    {
                        s.Append( clint.lstAdrClients[ i ].GetJson( ) );

                        if( i < clint.lstAdrClients.Count - 1 )
                            s.Append( "," );
                    }
                    s.Append( "]," );
                }
                s.Append( "}," );
            }

            if( !String.IsNullOrEmpty( DatTrans ) )
                s.AppendFormat( "\"datTrans\": \"{0}\",", DatTrans );

            if( !String.IsNullOrEmpty( Utc ) )
                s.AppendFormat( "\"utc\": \"{0}\",", Utc );


            // items
            if( lstItems.Count > 0 )
            {
                s.Append( "\"items\": [ " );

                for( int i = 0; i < lstItems.Count; i++ )
                {
                    s.Append( lstItems[ i ].GetJson( ) );
                    if( i < lstItems.Count - 1 )
                        s.Append( "," );
                }
                s.Append( "]," );
            }
            s.Append( "\"mont\": {" );
            if( !String.IsNullOrEmpty( AvantTax ) )
                s.AppendFormat( "\"avantTax\": \"{0}\"", AvantTax );

            if( !String.IsNullOrEmpty( TPS ) )
                s.AppendFormat( ",\"TPS\": \"{0}\"", TPS );

            if( !String.IsNullOrEmpty( TVQ ) )
                s.AppendFormat( ",\"TVQ\": \"{0}\"", TVQ );

            if( !String.IsNullOrEmpty( ApresTax ) )
                s.AppendFormat( ",\"apresTax\": \"{0}\"", ApresTax );

            if( !String.IsNullOrEmpty( VersActu ) )
                s.AppendFormat( ",\"versActu\": \"{0}\"", VersActu );

            if( !String.IsNullOrEmpty( VersAnt ) )
                s.AppendFormat( ",\"versAnt\": \"{0}\"", VersAnt );

            if( !String.IsNullOrEmpty( Solde ) )
                s.AppendFormat( ",\"sold\": \"{0}\"", Solde );

            if( !String.IsNullOrEmpty( Ajus ) )
                s.AppendFormat( ",\"ajus\": \"{0}\"", Ajus );

            if( !String.IsNullOrEmpty( MTDU ) )
                s.AppendFormat( ",\"mtdu\": \"{0}\"", MTDU );

            if( !String.IsNullOrEmpty( Pourb ) )
                s.AppendFormat( ",\"pourb\": \"{0}\"", Pourb );

            s.Append( "}," );

            if( !String.IsNullOrEmpty( NoDossFO ) )
                s.AppendFormat( "\"noDossFO\": \"{0}\",", NoDossFO );

            s.Append( "\"noTax\": {" );
            
            if( !String.IsNullOrEmpty( NoTPS ) )
                s.AppendFormat( "\"noTPS\": \"{0}\",", NoTPS );

            if( !String.IsNullOrEmpty( NoTVQ ) )
                s.AppendFormat( "\"noTVQ\": \"{0}\"", NoTVQ );

            s.Append( "}," );

            if( !String.IsNullOrEmpty( CommerceElectronique ) )
                s.AppendFormat( "\"commerElectr\": \"{0}\",", CommerceElectronique );

            if( !String.IsNullOrEmpty( TypTrans ) )
                s.AppendFormat( "\"typTrans\": \"{0}\",", TypTrans );

            if( !String.IsNullOrEmpty( ModPai ) )
                s.AppendFormat( "\"modPai\": \"{0}\",", ModPai );

            if( !String.IsNullOrEmpty( ModImpr ) )
                s.AppendFormat( "\"modImpr\": \"{0}\",", ModImpr );

            if( !String.IsNullOrEmpty( FormImpr ) )
                s.AppendFormat( "\"formImpr\": \"{0}\",", FormImpr );

            if( !String.IsNullOrEmpty( ModTrans ) )
                s.AppendFormat( "\"modTrans\": \"{0}\",", ModTrans );

            s.Append( "\"signa\": {" );
            if( !String.IsNullOrEmpty( signa.DatActu ) )
                s.AppendFormat( "\"datActu\": \"{0}\",", signa.DatActu );

            if( !String.IsNullOrEmpty( signa.Actu ) )
                s.AppendFormat( "\"actu\": \"{0}\",", signa.Actu );

            if( !String.IsNullOrEmpty( signa.Preced ) )
                s.AppendFormat( "\"preced\": \"{0}\"", signa.Preced );
            
            s.Append( "}," );

            // Références
            if( lsttransactionReferences.Count > 0 )
            {
                s.Append( "\"refs\": [ " );
                for( int i = 0; i < lsttransactionReferences.Count; i++ )
                {
                    s.Append( lsttransactionReferences[ i ].GetJson( ) );

                    if( i < lsttransactionReferences.Count - 1 )
                        s.Append( "," );
                }
                s.Append( "]," );
            }

            if( !String.IsNullOrEmpty( EmprCertifSEV ) )
                s.AppendFormat( "\"emprCertifSEV\": \"{0}\",", EmprCertifSEV );

            s.Append( "\"SEV\": {" );

            if( !String.IsNullOrEmpty( IdSev ) )
                s.AppendFormat( "\"idSEV\": \"{0}\",", IdSev );

            if( !String.IsNullOrEmpty( IdVersi ) )
                s.AppendFormat( "\"idVersi\": \"{0}\",", IdVersi );

            if( !String.IsNullOrEmpty( CodCertif ) )
                s.AppendFormat( "\"codCertif\": \"{0}\",", CodCertif );

            if( !String.IsNullOrEmpty( IdPartn ) )
                s.AppendFormat( "\"idPartn\": \"{0}\",", IdPartn );

            if( !String.IsNullOrEmpty( Versi ) )
                s.AppendFormat( "\"versi\": \"{0}\",", Versi );

            if( !String.IsNullOrEmpty( VersiParn ) )
                s.AppendFormat( "\"versiParn\": \"{0}\"", VersiParn );

            s.Append( "}" );

            return s.ToString( );
        }

        #endregion Fonctions publiques

    }
}
