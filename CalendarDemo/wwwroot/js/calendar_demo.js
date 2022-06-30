function init() {
    var data = getData();
    var scheduleObj = new ej.schedule.Schedule({
        width: '100%',
        height: `${window.innerHeight -20}px`,
        currentView: "Month",
        selectedDate: new Date(2022, 6, 3),
        eventSettings: {
            dataSource: data,
            template: '#apptemplate'
        },
        eventRendered: function (args,b,e) {
            var cellHeight = (scheduleObj.element.querySelector('.e-work-cells')).offsetHeight;
            var appHeight = cellHeight / 2 - 10;
            $($(args.element).find('.subject')).css('font-size', '16px');
            $($(args.element).find('.time')).css('font-size', '24px');
            args.element.style.height = appHeight + 'px';
        }
    });
    scheduleObj.appendTo('#Schedule');
    return scheduleObj;
};
$(document).ready(function () {
    var scheduleObj = init();
    console.log(getData());

    $('#print-btn').click(function() {
        scheduleObj.print();
    });
});