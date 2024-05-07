alert("yyyyyyyyyyy");

window.initializeDataTable = function (containerId, data) {
    alert("cccccc");
        $('#' + containerId).DataTable({
            data: data,
            columns: [
                { data: 'id' },
                { data: 'firstName' },
                { data: 'lastName' },
                { data: 'email' },
                { data: 'phoneNumber' },
                {
                    data: null,
                    render: function (data, type, row) {
                        return '<button class="btn btn-warning" onclick="NavigateToDeletePage(' + data.id + ')">Delete</button>';
                    }
                }
            ]
        });
    };

    function NavigateToDeletePage(contactId) {
        DotNet.invokeMethodAsync('YourAssemblyName', 'NavigateToDeletePage', contactId);
    }