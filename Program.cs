﻿using System;

namespace StudyInterface
{
    class MainClass
    {
        public static void Main(string[] args) {
            TheBrave theBrave = new TheBrave();
            for (int idx = 0; idx < theBrave.Equipments.Length; idx++) {
                // 装備が複数であることを知っている必要がある
                // nullになっている可能性を知っている必要がある
                if(theBrave.Equipments[idx] == null) {
                    break;
                }
                theBrave.Equipments[idx].Help();
                if(theBrave.Equipments[idx].GetType() == typeof(JourneySword)) {
                    // 攻撃
                }
            }
        }
    }
}
