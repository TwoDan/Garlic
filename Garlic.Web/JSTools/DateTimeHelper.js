




//获取今天日期2015-07-18形式
function GetDate() {
    var mydate = new Date();
    var str = "" + mydate.getFullYear() + "-";
    str += (mydate.getMonth() + 1) + "-";
    str += mydate.getDate();
    return str
}

//获取昨天日期2015-07-17形式
function GetYesDayDate() {
    var oneday = 1000 * 60 * 60 * 24;
    var today = new Date();
    var yesday = new Date(today - oneday);
    var str = "" + yesday.getFullYear() + "-";
    str += (yesday.getMonth() + 1) + "-";
    str += yesday.getDate();
    return str
}

//获取指定一天的前一天 2015-07-15形式
function GetYesterday(mydate) {
    var oneday = 1000 * 60 * 60 * 24;
    var date = new Date(mydate);
    var yesday = new Date(date - oneday);
    var str = "" + yesday.getFullYear() + "-";
    str += (yesday.getMonth() + 1) + "-";
    str += yesday.getDate();
    return str
}

