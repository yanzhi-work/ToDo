$(function () {

    var l = abp.localization.getResource('TodoApp');

    var service = todoApp.book;
    var createModal = new abp.ModalManager(abp.appPath + 'TodoApp/Book/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'TodoApp/Book/EditModal');

    var dataTable = $('#BookTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,
        autoWidth: false,
        scrollCollapse: true,
        order: [[0, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getList),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                visible: abp.auth.isGranted('TodoApp.Book.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('TodoApp.Book.Delete'),
                                confirmMessage: function (data) {
                                    return l('BookDeletionConfirmationMessage', data.record.id);
                                },
                                action: function (data) {
                                    service.delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(l('SuccessfullyDeleted'));
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                }
            },
            {
                title: l('BookName'),
                data: "name"
            },
            {
                title: l('BookPublishDate'),
                data: "publishDate"
            },
            {
                title: l('BookPrice'),
                data: "price"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewBookButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
