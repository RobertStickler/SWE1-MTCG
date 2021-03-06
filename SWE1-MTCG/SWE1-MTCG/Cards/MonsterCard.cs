﻿using Bogus.DataSets;
using Cards;
using MyEnum;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace SWE1_MTCG.Cards.Monster
{
    public class MonsterCard : BaseCards
    {
        public MonsterCard(string uid, int damage, string name, elementTypes element, cardProperty property) : base(damage, name, element)
        {
            this.card_type = cardTypes.Monster;
            this.card_property = property;
            this.uid = uid;
        }
    }
}
