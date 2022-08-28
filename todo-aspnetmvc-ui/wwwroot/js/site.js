/* Setting
-------------------------------------------------- */
const hideComplete = window.localStorage.getItem('hideCompleted');
const showOnlyDueDate = window.localStorage.getItem('showOnlyDueDate');

const hideCompletedCheckbox = document.getElementById('hideCompleted');
const showOnlyDueDateChecbox = document.getElementById('showOnlyDueDate');

if (hideCompletedCheckbox) {
    if (hideComplete === "true") {
        hideCompletedCheckbox.checked = true;
    }

    hideCompletedCheckbox.addEventListener('change', () => {
        window.localStorage.setItem('hideCompleted', hideCompletedCheckbox.checked)
    });
}

if (showOnlyDueDateChecbox) {
    if (showOnlyDueDate === "true") {
        showOnlyDueDateChecbox.checked = true;
    }

    showOnlyDueDateChecbox.addEventListener('change', () => {
        window.localStorage.setItem('showOnlyDueDate', showOnlyDueDateChecbox.checked)
    });
}

const items = [...document.getElementsByClassName('task')];
items.forEach(i => {
    if (hideComplete === "true") {
        if (i.dataset.completed === "Completed") {
            i.style.display = "none";
        }
    }

    if (showOnlyDueDate === "true") {
        if (i.dataset.duedate === "") {
            i.style.display = "none";
        }
    }
});

/* Reminder and notification
-------------------------------------------------- */
function hideRemind(el, id)
{
    window.localStorage.setItem(id, "hidden");
    let item = document.getElementById(id);

    el.style.display = "none";
    item.style.display = "none";
    window.location.reload();
}

const hiddenReminds = [...document.getElementsByClassName('remind')];
const showedNumber = document.getElementById('numberNotification');
let numberHiddenReminds = 0;


hiddenReminds.forEach(i => {
    let hide = window.sessionStorage.getItem(i.id);
    if (hide == "hidden") {
        i.style.display = "none";
        numberHiddenReminds = numberHiddenReminds + 1;
    }

    let numberRemind = hiddenReminds.length - numberHiddenReminds;

    window.sessionStorage.setItem('number', numberRemind);
});

if (hiddenReminds.length == 0) {
    if (window.sessionStorage.getItem('number') == null) {
        window.sessionStorage.setItem('number', '*');
    }
    else {
        window.sessionStorage.setItem('number', 0);
    }
}


showedNumber.textContent = window.sessionStorage.getItem('number');

/* Show status
-------------------------------------------------- */
const indeterminates = document.getElementsByClassName('indeterminate');

for (let i = 0; i < indeterminates.length; i++) {
    indeterminates[i].indeterminate = true;
}
