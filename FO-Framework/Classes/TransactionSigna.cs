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

namespace FO_Framework
{
    /// <summary>
    /// Le champ identifiant les signatures numériques générées par votre SEV pour la transaction.
    /// Field identifying the digital signatures generated by your SRS for the transaction.
    /// </summary>
    public class TransactionSigna
    {
        /// <summary>
        /// La signature numérique générée par votre SEV pour la facture actuelle.
        /// Field identifying the digital signatures generated by your SRS for the transaction.
        /// </summary>
        public String Actu { get; set; }

        /// <summary>
        /// La signature numérique générée par votre SEV pour la facture précédente.
        /// Digital signature generated by your SRS for the preceding bill.
        /// </summary>
        public String Preced { get; set; }

        /// <summary>
        /// Le moment où la signature actuelle est générée (date, heure, minute et seconde). Format AAAAMMJJhhmmss
        /// Time when the current signature is generated( date, hour, minute and second). Format AAAAMMJJhhmmss
        /// </summary>
        public String DatActu { get; set; }

        public TransactionSigna( ) { }

    }
}
