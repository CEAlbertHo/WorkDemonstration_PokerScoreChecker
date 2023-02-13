using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ShuffleUtil;

namespace Poker
{
     // µP²Õ¥Í¦¨
    public class DeckBuilder
    {
        public const int cPokerSuit_Min = 1;
        public const int cPokerSuit_Max = 4;

        public const int cPokerRank_Min = 1;
        public const int cPokerRank_Max = 13;


        public static CardDeck BuildStandardDeck( bool iIsShuffle = true )
        {
            List<Card> cards = new();
            for( int suit = cPokerSuit_Min; suit <= cPokerSuit_Max; suit++ )
            {
                for( int rank = cPokerRank_Min; rank <= cPokerRank_Max; rank++ )
                {
                    int cardIndex = ( suit - 1 ) * cPokerRank_Max + rank;
                    Card card = new( ECardType.Standard, cardIndex, suit, rank );
                    cards.Add( card );
                }
            }

            CardDeck deck = new()
            {
                Cards = cards
            };

            if( iIsShuffle )
                deck.Shuffle();

            return deck;
        }
    }

    // µP°ï
    public class CardDeck
    {
        public List<Card> Cards;

        public CardDeck()
        {
            Cards = new();
        }

        public void Shuffle( int iShuffleCount = 2 )
        {
            if( iShuffleCount <= 0 )
                return;

            for( int i = 0; i < iShuffleCount; i++ )
                Cards.Shuffle();
        }

        public void DealCardFromTop( CardDeck iTarget, int iDealNum = 1 )
        {
            if( iTarget == null )
                return;
            if( iDealNum <= 0 )
                return;
            if( Cards.Count <= iDealNum )
                return;

            for( int i = 0; i < iDealNum; i++ )
            {
                Card firstCard = Cards[ 0 ];
                Cards.RemoveAt( 0 );
                iTarget.ReceiveCard( firstCard );
            }
        }

        public void ReceiveCard( Card iReceivedCard )
        {
            if( iReceivedCard == null )
                return;

            Cards.Add( iReceivedCard );
        }

        public void AddOneSetOfDeck()
        {
            CardDeck newDeck = DeckBuilder.BuildStandardDeck( false );
            Cards.AddRange( newDeck.Cards );
        }

        public void Debug_LogNowCards()
        {
            string log = Newtonsoft.Json.JsonConvert.SerializeObject( Cards );
            Debug.Log( log );
        }
    }
}