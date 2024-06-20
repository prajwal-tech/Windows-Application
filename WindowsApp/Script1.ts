// server.ts
import express from 'express';
import bodyParser from 'body-parser';

const app = express();
const port = 3000;

app.use(bodyParser.json());

app.post('/submit', (req, res) => {
    const formData = req.body; // Replace with validation and data processing logic

    // Store data in database or file (replace with your storage solution)
    console.log('Received form data:', formData);

    res.send('Success'); // Or send appropriate error message
});

app.listen(port, () => {
    console.log(`Server listening on port ${port}`);
});

