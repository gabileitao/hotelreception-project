using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelreception_project {
    class Reserva {

        public List<Pessoa> Guest;
        public Suite Room;
        public int ReservedDays;

        public Reserva(List<Pessoa> guest, Suite room, int reservedDays) {
            Guest = guest;
            Room = room;
            ReservedDays = reservedDays;
        }

        public decimal GetPrice() {

            if (ReservedDays >= 10) {
                return (Room.DailyValue * ReservedDays) - ((Room.DailyValue * ReservedDays) * 0.1M);
            } else {
                return Room.DailyValue * ReservedDays;
            }
        }

    }
}
