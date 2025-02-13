document.addEventListener("DOMContentLoaded", function () {
    const form = document.getElementById("loveForm");
    const resultContainer = document.getElementById("resultContainer");
    const resultText = document.getElementById("result");
    const calculateAgainBtn = document.getElementById("calculateAgain");

    function resetForm() {
        if (form) {
            form.reset(); // Reset form fields
        }

        // Manually clear input fields (to ensure reset)
        document.getElementById("yourName").value = "";
        document.getElementById("partnersName").value = "";

        // Hide and clear result container
        if (resultContainer) {
            resultContainer.style.opacity = "0";
            resultContainer.style.display = "none"; // Fully hide container
        }
        if (resultText) {
            resultText.innerHTML = ""; // Clear text content
        }

        // Hide the "Calculate Again" button
        if (calculateAgainBtn) {
            calculateAgainBtn.style.display = "none";
        }
    }

    function showResultContainer() {
        if (resultText && resultText.innerHTML.trim() !== "") {
            resultContainer.style.opacity = "1";
            resultContainer.style.display = "block"; // Ensure it's visible
            calculateAgainBtn.style.display = "block";
        } else {
            resultContainer.style.opacity = "0";
            resultContainer.style.display = "none"; // Hide if no result
        }
    }

    // Check if result already exists on page load
    showResultContainer();

    if (calculateAgainBtn) {
        calculateAgainBtn.addEventListener("click", function (event) {
            event.preventDefault(); // Prevent unwanted form submission
            resetForm();
        });
    }
});
