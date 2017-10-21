$('.filter-buttons').on('click', 'button', function () {
    var Filter = $(this).data('filter');
    if (Filter == "*") $('.filter-content').find('.element-item').show();
    else {
        $('.filter-content').find('.element-item').hide();
        $('.filter-content').find(Filter).show();
    }
});