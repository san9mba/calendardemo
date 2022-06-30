var CalendarModels = {
    shift: {
        1: {
            Title: "Morning",
            From: "7:00",
            To: "19:00",
            Color: "#0d6efd"
        },
        2: {
            Title: "Evening",
            From: "15:00",
            To: "22:00",
            Color: "#146c43"
        }
    },
    physician: {
        1: {
            FirstName: "Michael",
            LastName: "Thompson"
        },
        2: {
            FirstName: "Alice",
            LastName: "Madison"
        }
    }
},
    MockData = [{
        Date: "07/03/2022",
        physicianId: 1,
        shiftId: 2
    },
    {
        Date: "07/03/2022",
        physicianId: 2,
        shiftId: 1
    },
    {
        Date: "07/04/2022",
        physicianId: 1,
        shiftId: 2
    },
    {
        Date: "07/04/2022",
        physicianId: 2,
        shiftId: 1
        },
        {
            Date: "07/14/2022",
            physicianId: 2,
            shiftId: 1
        }
    ];

function getData() {
    var calendarData = [];
    for (var i = 0; i < MockData.length; i++) {
        var d = MockData[i],
            date = d.Date,
            shift = CalendarModels.shift[d.shiftId],
            physician = CalendarModels.physician[d.physicianId];
        calendarData.push({
            Id: i,
            Subject: shift.Title,
            PhysicianName: `${physician.FirstName} ${physician.LastName}`,
            CategoryColor: shift.Color,
            StartTime: new Date(`${date} ${shift.From}`),
            EndTime: new Date(`${date} ${shift.To}`),
        });
    }
    return calendarData;
}
