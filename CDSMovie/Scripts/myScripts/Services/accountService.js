
var accountService = function () {

    this.getAccounts = function () {
        var accounts = [];

        $.get("http://localhost:49974/api/AccountLoggin/", function (data) {
                for (i = 0; i < data.length; i++) {
                    accounts.push({
                        UserName: data[i].UserName
                    });
                }

                //movies = data;
            });
        return accounts;
    };
};