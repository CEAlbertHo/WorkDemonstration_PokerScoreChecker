using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Poker
{
    // 卡片類別
    public enum ECardType
    {
        Standard,
        Joker
    }

    // 花色
    public enum EPokerSuit : int
    {
        Spades   = 4,
        Hearts   = 3,
        Diamonds = 2,
        Clubs    = 1,
    }

    // 牌階
    public enum EPokerRank : int
    {
        Number2  = 1,
        Number3  = 2,
        Number4  = 3,
        Number5  = 4,
        Number6  = 5,
        Number7  = 6,
        Number8  = 7,
        Number9  = 8,
        Number10 = 9,
        Jack     = 10,
        Queen    = 11,
        King     = 12,
        Ace      = 13,
    }

    // 撲克牌種類
    public enum EPokerCardType
    {
        // Clubs
        C2  = 1,
        C3  = 2,
        C4  = 3,
        C5  = 4,
        C6  = 5,
        C7  = 6,
        C8  = 7,
        C9  = 8,
        C10 = 9,
        CJ  = 10,
        CQ  = 11,
        CK  = 12,
        CA  = 13,

        // Diamonds
        D2  = 14,
        D3  = 15,
        D4  = 16,
        D5  = 17,
        D6  = 18,
        D7  = 19,
        D8  = 20,
        D9  = 21,
        D10 = 22,
        DJ  = 23,
        DQ  = 24,
        DK  = 25,
        DA  = 26,

        // Hearts
        H2  = 27,
        H3  = 28,
        H4  = 29,
        H5  = 30,
        H6  = 31,
        H7  = 32,
        H8  = 33,
        H9  = 34,
        H10 = 35,
        HJ  = 36,
        HQ  = 37,
        HK  = 38,
        HA  = 39,

        // Spades
        S2  = 40,
        S3  = 41,
        S4  = 42,
        S5  = 43,
        S6  = 44,
        S7  = 45,
        S8  = 46,
        S9  = 47,
        S10 = 48,
        SJ  = 49,
        SQ  = 50,
        SK  = 51,
        SA  = 52,

        // Special
        Joker,
    }

    // 卡片
    public class Card
    {
        public int PokerCardType;
        public ECardType CardType;
        public int CardIndex;
        public int Suit;
        public int Rank;
        public string CardStrInfo;

        /*private float mWeight;
        public float Weight
        {
            get => mWeight;
            set
            {
                if( value < 0f )
                    return;

            }
        }*/

        public Card( ECardType iCardType, int iCardIndex, int iSuit, int iRank )
        {
            CardType = iCardType;
            Suit = iSuit;
            Rank = iRank;
            CardStrInfo = $"{ ((EPokerSuit)iSuit).ToString() }-{ ((EPokerRank)iRank).ToString() }";
        }
    }
}