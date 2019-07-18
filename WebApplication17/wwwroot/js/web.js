window.setInputFocus = function (input) {
    const o = document.getElementById(input);
    if (o) {        
        o.focus();
        return true;
    }
    return false;
};

window.setMaskInput = function (input) {
    const o = document.getElementById(input);
    o.addEventListener('keydown', e => {        
        const keyCode = window.event ? event.keyCode : e.which;        
        if (keyCode === 109 ||
            keyCode === 189 ||
            keyCode === 8 ||
            keyCode === 9 ||
            keyCode === 0 ||
            keyCode === 13 ||
            (keyCode >= 96 && keyCode <= 105)) {
            return true;
        }
        e.preventDefault();
        return false;
    });
    o.addEventListener('keyup', e => {
        if (e.target.value.length === 5) {
            e.target.value =
                e.target.value + "-";
        }
    });
};