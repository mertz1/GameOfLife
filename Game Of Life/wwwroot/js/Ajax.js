$(function () {
    Host = document.location.href,

    Ajax = {
        Get: function Get(url, data, callback, error) {
            $.ajax({
                url: url,
                type: 'GET',
                data: data,
                success: function (res) {
                    callback(res);
                },
                error: function (res) {
                    alert("error: " + res);
                }
            })
        },
        Post: function Post(url, data, callback, error) {
            $.ajax({
                url: url,
                type: 'POST',
                data: data,
                success: function (res) {
                    callback(res);
                },
                error: function (res) {
                    alert("error: " + res);
                }
            })
        }
    }
});