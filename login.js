const form = document.getElementById('register-form');
form.addEventListener('submit', async (event) => {
    event.preventDefault();
    const data = new FormData(form);
    const response = await fetch('/User/Register', {
        method: 'POST',
        body: data,
    });
    const result = await response.json();
    console.log(result);
});